using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggler : MonoBehaviour {

	AudioSource audioSource;
	[SerializeField] Animator animator;
	[SerializeField] AudioClip good, bad;
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
	[SerializeField] GameObject[] OnlyVeiwHidden;
	[HideInInspector]
	public bool flipScene = false;
	

	void Start()
	{
		fire = QuestionController.Fire;
		heights = QuestionController.Heights;
		people = QuestionController.People;
		space = QuestionController.Spaces;
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = bad;
		audioSource.Play();
		ChangeScene();
	}

	void Update(){
		
		if(hiding != InputController.hiding)
		{
			if(InputController.hiding)
			{
				audioSource.clip = good;
				audioSource.Play();
			}
			else
			{
				audioSource.clip = bad;
				audioSource.Play();
			}
			fire = !fire;
			heights = !heights;
			people = !people;
			space = !space;			
			hiding = InputController.hiding;
		}
		transform.position = Camera.main.transform.position;
		if(DetectBoolChange()){
			animator.SetBool("hiding", hiding);
		}
		if(flipScene)
		{
			ChangeScene();
			flipScene = false;
		}
	}
    public void ChangeScene()
    {
		print("running this");
		if(hiding)
		{
			Active(OnlyVeiwHidden);
		}
		else{
			InActive(OnlyVeiwHidden);
		}
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
		if(!people)
		{
			Active(peopleChangeSetBad);
			InActive(peopleChangeSetGood);
		}
		else
		{
			Active(peopleChangeSetGood);
			InActive(peopleChangeSetBad);
		}
    }

    private void CheckSpace()
    {
        if (!space)
        {
            heightChangeSetBad[2].SetActive(false);
			heightChangeSetBad[1].SetActive(false);
            heightChangeSetGood[1].SetActive(false);
			Active(spaceChangeSetBad);
			if(!heights)
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
