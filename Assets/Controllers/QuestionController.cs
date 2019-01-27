using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionController : MonoBehaviour {
public static bool People, Fire, Spaces, Heights;
private bool shown = false;
//testing boolean
private int arrayValue;
private Image QuestionImage;
public Sprite image1, image2, image3, image4;

	// Use this for initialization
	void Start () {
		arrayValue = 0;
		QuestionImage = FindObjectOfType<currentimage>().GetComponent<Image>();
		SetCurrentQuestion();
	}
	
	// Update is called once per frame
	void Update () {
		NextScene();
	}

	void SetCurrentQuestion()
	{

		switch (arrayValue)
		{
			case 0:
			QuestionImage.sprite = image1;
			break;

			case 1:
			QuestionImage.sprite = image2;
			break;
			
			case 2:
			QuestionImage.sprite = image3;	
			break;

			case 3:
			QuestionImage.sprite = image4;
			break;

			default:
			print("No question");
			break;
		}
	}

	void SetGoodOrBad(bool ButtonPressed)
	{
		switch (arrayValue)
		{
			case 0:
			People = ButtonPressed;
			break;

			case 1:
			Fire = ButtonPressed;
			break;
			
			case 2:
			Spaces = ButtonPressed;
			break;

			case 3:
			Heights = ButtonPressed;
			break;

			default:
			print("No question");
			break;
		}
	}


	public void Good()
	{
		if(arrayValue < 4)
		{
		SetGoodOrBad(true);
		arrayValue++;
		SetCurrentQuestion();
		}

	}

	public void Bad()
	{
		if(arrayValue < 4)
		{
		SetGoodOrBad(false);
		arrayValue++;
		SetCurrentQuestion();
		}
	}

	void NextScene()
	{

		if(arrayValue == 4 && !shown)
		{
		print(People + " " + Fire + " " + Spaces + " " + Heights);
		shown = true;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

	}
}
