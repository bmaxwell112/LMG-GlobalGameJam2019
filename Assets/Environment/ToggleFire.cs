using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFire : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ChooseModel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChooseModel()
	{
		if(!QuestionController.Fire)
		{
			//Fire Particles object, remove when hiding
		}
	}
}
