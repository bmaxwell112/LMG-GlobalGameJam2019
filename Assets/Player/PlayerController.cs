using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed = 1f;
    public float TurnSpeed = 100f;

    private Rigidbody rb;

   //private Transform groundChecker;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        MoveWithCam();
    }

    private void FixedUpdate()
    {
        ApplyGravity();

    }

    void ApplyGravity()
    {
        rb.AddForce(new Vector3(0, PhysicsController.gravityTime, 0));
    }


    void MoveWithCam()
    {
        print(InputController.vMove);
        if(InputController.vMove > 0)
        {            
            transform.position += Camera.main.transform.forward * (Time.deltaTime * Speed);    
        }

        if(InputController.vMove < 0)
        {
            transform.position += new Vector3(-Camera.main.transform.forward.x, 0, -Camera.main.transform.forward.z) * (Time.deltaTime * Speed);
        }

        //make these work relative to the camera!!

        if(InputController.hMove > 0)
        {
           transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
        }

        if (InputController.hMove < 0)
        {
            transform.Rotate(-Vector3.up, TurnSpeed * Time.deltaTime);
        }
        // Keeps player frop tipping      
        Quaternion newRot = Quaternion.identity;
        newRot.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        transform.rotation = newRot;
    }





}
