using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpaces : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ChooseModel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChooseModel()
	{
		if(QuestionController.Spaces)
		{
			//No walls until hiding
		}
		else
		{
			//Generate more objects, closer walls, remove walls when hiding
		}
	}
}
