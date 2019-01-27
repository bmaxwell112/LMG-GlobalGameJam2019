using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackHearts : MonoBehaviour {

public static int hearts;

public Sprite halfheart;
public Sprite fullheart;


	// Use this for initialization
	void Start () {
		hearts = 0;
		GetComponent<Image>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(hearts == 1)
		{
			GetComponent<Image>().enabled = true;
			GetComponent<Image>().sprite = halfheart;
		}

		if(hearts == 2)
		{
			GetComponent<Image>().sprite = fullheart;
		}
	}
}
