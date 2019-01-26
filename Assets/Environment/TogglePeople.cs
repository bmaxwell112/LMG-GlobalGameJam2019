using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePeople : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ChooseModel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChooseModel()
	{
		if(QuestionController.People)
		{
			//Normal humans when hiding
		}
		else
		{
			//Warped humans in real world
		}
	}
}
