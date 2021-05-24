using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed;
    public float jumpSpeed;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        walkSpeed = 2f;
        jumpSpeed = 3;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = new Vector2(walkSpeed, rb.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-walkSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}
