using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideCheck : MonoBehaviour {

private Image image;

public Sprite image1;
public Sprite image2;

	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		HideState();
	}

	void HideState()
	{
		if(InputController.hiding)
		{
			image.sprite = image1;
		}
		else
		{
			image.sprite = image2;
		}
	}
}
