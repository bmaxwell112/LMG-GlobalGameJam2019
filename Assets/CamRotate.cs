using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour {

	[SerializeField] float turnSpeed = 50;
	[SerializeField] float moveSpeed = 5;
	Vector3 left = new Vector3(0,-1,0);
	Vector3 right = new Vector3(0,1,0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RotateCamera();
	}

	void RotateCamera()
	{
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(left * turnSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(right * turnSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}
	}
}
