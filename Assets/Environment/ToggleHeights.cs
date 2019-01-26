using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHeights : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ChooseModel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChooseModel()
	{
		if(QuestionController.Heights)
		{
			//No changes until hiding
			Windows();
		}
		else
		{
			//High in the sky, on ground when hiding
			Windows();
		}
	}

	void Windows()
	{
			if(QuestionController.Spaces && QuestionController.Heights || !QuestionController.Spaces && QuestionController.Heights || QuestionController.Spaces && !QuestionController.Heights)
			{
				//Standard windows
			}

			if(!QuestionController.Spaces && !QuestionController.Heights)
			{
				//Windows with bars
			}
	}
}
