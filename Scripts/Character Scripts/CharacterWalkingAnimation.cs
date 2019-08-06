using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWalkingAnimation : MonoBehaviour
{

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {


        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {

            anim.Play("Running Cycle");//plays specified animation


        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E) || Input.GetAxis("Mouse X") !=0)
        {

            anim.Play("Walking Cycle");//plays specified animation


        }
    }
}
