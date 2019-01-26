using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour {
bool[] questions = {People, Fire, Spaces, Heights};
public static bool People, Fire, Spaces, Heights;
private bool currentBoolean;
private int arrayValue;
private Image QuestionImage;
public Sprite image1, image2, image3, image4;

	// Use this for initialization
	void Start () {

		arrayValue = 0;
		QuestionImage = FindObjectOfType<currentimage>().GetComponent<Image>();
		SetCurrentBoolean(questions[0]);
	}
	
	// Update is called once per frame
	void Update () {
		SetCurrentQuestion();
	}

	void SetCurrentBoolean(bool question)
	{
		question = currentBoolean;
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

	public void Good()
	{
		currentBoolean = true;
		if(arrayValue < 3)
		{
		arrayValue++;
		SetCurrentBoolean(questions[arrayValue]);
		}
		else
		{
			NextScene();
		}

	}

	public void Bad()
	{
		currentBoolean = false;
		if(arrayValue < 3)
		{
		arrayValue++;
		SetCurrentBoolean(questions[arrayValue]);
		}
		else
		{
			NextScene();
		}
	}

	void NextScene()
	{
		print(questions[0]);
	}
}
