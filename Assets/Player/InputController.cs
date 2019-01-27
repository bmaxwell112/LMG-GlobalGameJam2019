using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    public static float hMove, vMove;
    public static bool hiding;

    private Quaternion storedPlayerRotation;

    private PlayerController player;

    private void Start() 
    {
        player = FindObjectOfType<PlayerController>();
    }

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
            storedPlayerRotation.y = player.transform.rotation.y;
            print(player.transform.rotation.y);
            hiding = true;

        }
        else
        {
            player.transform.rotation = new Quaternion(0, storedPlayerRotation.y, 0, 1);
            hiding = false;
        }
    }
}
