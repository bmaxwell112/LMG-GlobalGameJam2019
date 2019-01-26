﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    public static float hMove, vMove;
    public static bool hiding;

    private void Update()
    {
        InputCheck();

        if(Input.GetButtonUp("Hide"))
        {
            ToggleHide();
        }

        if(Input.GetButton("Interact"))
        {
            //do this
        }
    }

    public static void InputCheck()
    {
        hMove = Input.GetAxis("Horizontal");
        vMove = Input.GetAxis("Vertical");
    }

    public void ToggleHide()
    {
        if(!hiding)
        {
            hiding = true;
        }
        else
        {
            hiding = false;
        }
    }
}
