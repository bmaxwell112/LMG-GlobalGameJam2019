using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour {

public bool[] questions;
public static bool People, Fire, Spaces, Heights;
private bool currentBoolean;
private Image QuestionImage;
public Sprite image1, image2, image3, image4;

	// Use this for initialization
	void Start () {
		bool[] questions = new bool[]{People, Fire, Spaces, Heights};

		QuestionImage = FindObjectOfType<currentimage>().GetComponent<Image>();
		QuestionImage.sprite = image1;
		SetCurrentBoolean(questions[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetCurrentBoolean(bool question)
	{
		currentBoolean = question;
	}

	public void Good()
	{
		currentBoolean = true;
		
	}

	public void Bad()
	{
		currentBoolean = false;
		//increment to next boolean in array
	}
}
