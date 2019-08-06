using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public Rigidbody rb;
    private bool grounded;
    private Transform tr;
    private int jumpCount;
    
    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //moveDir.y -= Physics.gravity * Time.deltaTime;

        if (Input.GetKey("d"))
        {
            tr.Translate(4*Time.deltaTime, 0, 0);
            if (Input.GetKeyDown("left shift"))
            {
                tr.Translate(8 * Time.deltaTime, 0, 0);
            }


        }

        if (Input.GetKey("a"))
        {
            tr.Translate(4*-Time.deltaTime, 0, 0);
            if (Input.GetKey("left shift"))
            {
                tr.Translate(8 * -Time.deltaTime, 0, 0);
            }
        }

        if (Input.GetKey("s"))
        {
            tr.Translate(0, 0, 4*-Time.deltaTime);
           
            if (Input.GetKey("left shift"))
                tr.Translate(0, 0, 8 * -Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            
            tr.Translate(0, 0, 4*Time.deltaTime);
            if (Input.GetKey("left shift"))
                tr.Translate(0, 0, 8 * Time.deltaTime);
        }

        if (Input.GetAxis("Mouse X") > 0)
        {

            tr.Rotate(0,Input.GetAxis("Mouse X"), 0);
            
        }

        if (Input.GetAxis("Mouse X") < 0)
        {

            tr.Rotate(0,Input.GetAxis("Mouse X"), 0);

        }
        if (Input.GetKeyDown("space") && jumpCount < 1)
         {

            tr.Translate(0, 250 * Time.deltaTime, 0);
            jumpCount++;

         }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            jumpCount = 0;
        }
    }

}
