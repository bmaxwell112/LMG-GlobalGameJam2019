using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackHearts : MonoBehaviour {

public static int hearts;



	// Use this for initialization
	void Start () {
		hearts = 0;
		print(hearts);
		FindObjectOfType<heart1>().GetComponent<Image>().enabled = false;
		FindObjectOfType<heart2>().GetComponent<Image>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(hearts == 1)
		{
			FindObjectOfType<heart1>().GetComponent<Image>().enabled = true;
		}

		if(hearts == 2)
		{
			FindObjectOfType<heart2>().GetComponent<Image>().enabled = true;
		}
	}
}
