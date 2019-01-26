using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWarmth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ChooseModel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChooseModel()
	{
		if(QuestionController.Fire)
		{
			//world is colder, warmer when hiding
		}
	}
}
