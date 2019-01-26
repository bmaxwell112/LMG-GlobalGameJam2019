using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneTransition : MonoBehaviour {
	public float fadeInTime;
	
	private Image fadePanel;
	private Color currentColor;
	

	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image>();		
	}
	
	// Update is called once per frame
	void Update () {
		CheckForHide();
	}

	void CheckForHide()
	{
		if(Input.GetButtonUp("Hide"))
		{
		if (!InputController.hiding){
			//fade in
			currentColor = Color.black;
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColor.a += alphaChange;
			fadePanel.color = currentColor;
			//do a thing
			StartCoroutine(FadeBack());

		} 
		else
		{
			currentColor = Color.white;
			float alphaChange = -Time.deltaTime / fadeInTime;
			currentColor.a += alphaChange;
			fadePanel.color = currentColor;
			//revert a thing
			
		}
		}
	}

	IEnumerator FadeBack()
	{
		yield return new WaitForSeconds(2);
				print("Fading back");
		fadePanel.color = currentColor;
		currentColor.a -= Time.deltaTime / fadeInTime;
	}
}
