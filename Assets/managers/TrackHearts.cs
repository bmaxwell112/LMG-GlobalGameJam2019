using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackHearts : MonoBehaviour {

public static int hearts;

	// Use this for initialization
	void Start () {
		hearts = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//replace this with heart images
		Text heartCount = GetComponentInChildren<Text>();
		heartCount.text = hearts.ToString();
	}
}
