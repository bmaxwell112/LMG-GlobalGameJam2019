using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEscape : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Object.DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Quit"))
		{
			Application.Quit();
		}
	}


}
