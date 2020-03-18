using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float movementSpeed = 5f;
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        //update the position
        Animator animator = FindObjectOfType<Animator>();
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);
        MoveAnimation(horizontalInput, verticalInput, animator);
    }

    private static void MoveAnimation(float horizontalInput, float verticalInput, Animator animator)
    {
        if (horizontalInput < 0)
        {
            animator.SetBool("Move left", true);
            animator.SetBool("Move right", false);
            animator.SetBool("Move up", false);
            animator.SetBool("Move down", false);
        }
        else if (horizontalInput > 0)
        {
            animator.SetBool("Move left", false);
            animator.SetBool("Move right", true);
            animator.SetBool("Move up", false);
            animator.SetBool("Move down", false);
        }
        else if (verticalInput < 0)
        {
            animator.SetBool("Move left", false);
            animator.SetBool("Move right", false);
            animator.SetBool("Move up", false);
            animator.SetBool("Move down", true);

        }
        else if (verticalInput > 0)
        {
            animator.SetBool("Move left", false);
            animator.SetBool("Move right", false);
            animator.SetBool("Move up", true);
            animator.SetBool("Move down", false);
        }
    }
}
