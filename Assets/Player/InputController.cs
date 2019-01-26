using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    public static float hMove, vMove;

    private void Update()
    {
        InputCheck();
    }

    public static void InputCheck()
    {
        hMove = Input.GetAxis("Horizontal");
        vMove = Input.GetAxis("Vertical");
    }
}
