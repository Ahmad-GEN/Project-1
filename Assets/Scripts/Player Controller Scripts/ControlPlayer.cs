using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public Animator animator;
    private readonly float PlayerSpeed = 5f;
    Rigidbody rb;
    public Joystick jstick;
    private readonly float RotationSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jstick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.TransformDirection(new Vector3(jstick.Horizontal * PlayerSpeed, rb.velocity.y, 
                                                   jstick.Vertical * PlayerSpeed));
        
        if (jstick.Horizontal >= 0.1f || jstick.Horizontal <= -0.1f)
        {
            transform.Rotate(new Vector3(0, jstick.Horizontal * RotationSpeed, 0));
        }

        if (jstick.Horizontal != 0f || jstick.Vertical != 0f)
        {
            animator.SetBool("Walk", true);
            //transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}
