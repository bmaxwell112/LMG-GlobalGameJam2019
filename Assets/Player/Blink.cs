using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

	Toggler toggler;
	private void Start() {
		toggler = FindObjectOfType<Toggler>();
	}

	public void TriggerChange()
	{
		toggler.ChangeScene();
	}
}
