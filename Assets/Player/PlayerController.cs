using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed = 1f;
    public float TurnSpeed = 100f;
    public float interactRange = 5f;
    private Rigidbody rb;

    private int layerMask;


   //private Transform groundChecker;
    // Use this for initialization
    void Start()
    {
        layerMask = 1 << 8;
        layerMask = ~layerMask;


        rb = GetComponent<Rigidbody>();
        InputController.hiding = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(!InputController.hiding)
        {
        MoveWithCam();
        }
        else
        {
        LookWithCam();
        }
    }

    private void FixedUpdate()
    {
        CheckInteraction();
        ApplyGravity();

    }

    void ApplyGravity()
    {
        rb.AddForce(new Vector3(0, PhysicsController.gravityTime, 0));
    }


    void MoveWithCam()
    {
        if(InputController.vMove > 0)
        {                        
            transform.position += Camera.main.transform.forward * (Time.deltaTime * Speed);    
        }

        if(InputController.vMove < 0)
        {
            transform.position += new Vector3(-Camera.main.transform.forward.x, 0, -Camera.main.transform.forward.z) * (Time.deltaTime * Speed);
        }

        if(InputController.hMove > 0)
        {
           transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
        }

        if (InputController.hMove < 0)
        {
            transform.Rotate(-Vector3.up, TurnSpeed * Time.deltaTime);
        }
        // Keeps player from tipping      
        Quaternion newRot = Quaternion.identity;
        newRot.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        transform.rotation = newRot;
    }

        void LookWithCam()
    {
        if(InputController.vMove > 0)
        {            
            Camera.main.transform.Rotate(Vector3.left, TurnSpeed * Time.deltaTime);
        }

        if(InputController.vMove < 0)
        {
            Camera.main.transform.Rotate(-Vector3.left, TurnSpeed * Time.deltaTime);
        }

        if(InputController.hMove > 0)
        {
           transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
        }

        if (InputController.hMove < 0)
        {
            transform.Rotate(-Vector3.up, TurnSpeed * Time.deltaTime);
        }

                // Keeps player from tipping      
        Quaternion newRot = Quaternion.identity;
        newRot.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        transform.rotation = newRot;
    }

    void CheckInteraction()
    {
        RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, interactRange, layerMask))
        {
            if(hit.transform.tag == "Interact" && Input.GetButtonUp("Interact"))
            {
                hit.collider.gameObject.GetComponent<OnInteract>().PerformInteraction();
            }
        }
    }

}
