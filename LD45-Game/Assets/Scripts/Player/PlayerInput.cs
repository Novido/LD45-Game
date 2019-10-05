using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // This class takes all inputs from the player

    Animator animator;

    float speed = 4.0f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunningLeft", false);
        animator.SetBool("isRunningRight", false);

        //Keyboard movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            animator.SetBool("isRunningLeft", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            animator.SetBool("isRunningLeft", true);
            //animator.Play("Running_Left_anim");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            animator.SetBool("isRunningRight", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            animator.SetBool("isRunningRight", true);
        }

    }
}
