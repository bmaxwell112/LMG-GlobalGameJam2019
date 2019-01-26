using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed = 1f;
    public float maxSpeed = 2f;
    
    public LayerMask ground;
    public Vector3 Drag;

    private Rigidbody rb;
    private bool isGrounded = false;

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
        ChangeDrag();
        ApplyGravity();

    }

    void ApplyGravity()
    {
        rb.AddForce(new Vector3(0, PhysicsController.gravityTime, 0));
    }

    void ChangeDrag()
    {
        if(!isGrounded)
        {
            rb.drag -= Time.deltaTime;
        }
        else
        {
            rb.drag = 1;
        }
    }


    void MoveWithCam()
    {

        
        Quaternion playerRotation = new Quaternion (0, Camera.main.transform.rotation.y, 0, 1);

        transform.rotation = playerRotation;

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
           Camera.main.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        }

        if (InputController.hMove < 0)
        {
            Camera.main.transform.Rotate(-Vector3.up, 10 * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }






}
