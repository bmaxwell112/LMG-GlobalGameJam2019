﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteract : MonoBehaviour {

		enum Interactions { button, collect, door }

		[SerializeField] Interactions interactions;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PerformInteraction()
	{
		if(interactions == Interactions.collect)
		{
			TrackHearts.hearts++;
			Destroy(gameObject);
		}

		if(interactions == Interactions.button)
		{
			//cycle through button pictures
		}

		if(interactions == Interactions.door)
		{
			if(TrackHearts.hearts == 2)
			{
				//open door
			}
		}
	}

}
