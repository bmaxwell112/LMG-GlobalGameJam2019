using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneTransition : MonoBehaviour {
	public float fadeInTime;
	
	private Image fadePanel;
	private Color currentColor;
	
	// Use this for initialization
	void Start () {
		currentColor = Color.black;
		fadePanel = GetComponent<Image>();		
	}
	
	// Update is called once per frame
	void Update () {

		float alphaChange = Time.deltaTime / fadeInTime;
		currentColor.a -= alphaChange;
		fadePanel.color = currentColor;
	}
}