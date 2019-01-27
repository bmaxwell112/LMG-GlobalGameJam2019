using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggler : MonoBehaviour {

	[SerializeField] bool fire;
	[SerializeField] GameObject[] fireChangeSetBad;
	[SerializeField] GameObject[] fireChangeSetGood;
	[SerializeField] bool heights;
	[SerializeField] GameObject[] heightChangeSetBad;
	[SerializeField] GameObject[] heightChangeSetGood;
	[SerializeField] bool people;
	[SerializeField] GameObject[] peopleChangeSetBad;
	[SerializeField] GameObject[] peopleChangeSetGood;
	[SerializeField] bool space;
	[SerializeField] GameObject[] spaceChangeSetBad;
	[SerializeField] GameObject[] spaceChangeSetBadInside;
	
	[SerializeField] GameObject[] spaceChangeSetBadOutside;
	[SerializeField] GameObject[] spaceChangeSetGood;
	
	[SerializeField] bool warmth;
	[SerializeField] GameObject[] warthChangeSetBad;
	[SerializeField] GameObject[] warthChangeSetGood;
	bool[] check = new bool[5];
	bool hiding;

	void Start()
	{
		fire = QuestionController.Fire;
		heights = QuestionController.Heights;
		people = QuestionController.People;
		space = QuestionController.Spaces;
		ChangeScene();
	}

	void Update(){
		if(DetectBoolChange()){
			ChangeScene();
		}
		if(hiding != InputController.hiding)
		{
			fire = !fire;
			heights = !heights;
			people = !people;
			space = !space;
			hiding = InputController.hiding;
		}
	}

    private void ChangeScene()
    {
		print("running this");
        if(fire)
		{
			// Do fire things
		}
		if(!heights)
        {
            // Normal
            Active(heightChangeSetBad);
            InActive(heightChangeSetGood);
            CheckSpace();
        }
        else
		{
			Active(heightChangeSetGood);
			InActive(heightChangeSetBad);
			CheckSpace();
		}
    }

    private void CheckSpace()
    {
        if (!space)
        {
            heightChangeSetBad[0].SetActive(false);
            heightChangeSetBad[2].SetActive(false);
            heightChangeSetGood[1].SetActive(false);
			Active(spaceChangeSetBad);
			if(heights)
			{
				Active(spaceChangeSetBadOutside);
				InActive(spaceChangeSetBadInside);
			}
			else
			{
				Active(spaceChangeSetBadInside);
				InActive(spaceChangeSetBadOutside);
			}  
			InActive(spaceChangeSetGood);          
        }
        else
        {
            Active(spaceChangeSetGood);
			InActive(spaceChangeSetBad);
            InActive(spaceChangeSetBadInside);
			InActive(spaceChangeSetBadOutside);
        }
    }

    void Active(GameObject[] go){
		foreach (GameObject item in go)
		{
			item.SetActive(true);
		}
	}
	void InActive(GameObject[] go){
		foreach (GameObject item in go)
		{
			item.SetActive(false);
		}
	}

    bool DetectBoolChange()
    {
        if(check[0] != fire)
		{
			check[0] = fire;
			return true;
		}
		if(check[1] != heights)
		{
			print("this happened");
			check[1] = heights;
			return true;
		}
		if(check[2] != people)
		{
			check[2] = people;
			return true;
		}
		if(check[3] != space)
		{
			check[3] = space;
			return true;
		}
		if(check[4] != warmth)
		{
			check[4] = warmth;
			return true;
		}
		return false;
    }
}
