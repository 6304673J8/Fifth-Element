﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    //Movement
    Vector2 move;
    Rigidbody2D rb;
    public bool canMove = false;
    //Platform Check
    //public Transform groundPoint;
    //public LayerMask whatIsGround;
    //private bool isGrounded = true;
    private int indexScene;
    public float walkSpeed, jumpSpeed;

    //Animator
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        indexScene = 0;
        walkSpeed = 6f;
        jumpSpeed = 8f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        animator.SetBool("isGrounded", GroundCheck.isGrounded);

        if(rb.velocity.x > 0f)
        {
            transform.localScale = Vector3.one;
        }
        else if(rb.velocity.x < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move.x * walkSpeed, rb.velocity.y);
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        move.x = ctx.ReadValue<Vector2>().x;
    }
    public void Jump(InputAction.CallbackContext ctx)
    {
        if (GroundCheck.isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Door"))
        {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }

        if(collision.CompareTag("Door2"))
        {
            SceneManager.LoadScene("VictoryScene", LoadSceneMode.Single);
        }

        if(collision.CompareTag("FireBlock"))
        {
            SceneManager.LoadScene("TutorialSceneBackup", LoadSceneMode.Single);
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Magma"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
