using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement
    Vector2 move;
    Rigidbody2D rb;
    public bool canMove = false;
    //bool facingRight = true;
    [SerializeField] ParticleSystem water_particles;
    [SerializeField] ParticleSystem fire_particles;
    [SerializeField] ParticleSystem earth_particles;
    [SerializeField] ParticleSystem air_particles;
    //Platform Check
    //public Transform groundPoint;
    //public LayerMask whatIsGround;
    //private bool isGrounded = true;

    public float walkSpeed, jumpSpeed;

    //Animator
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        walkSpeed = 6f;
        jumpSpeed = 6f;
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

        //check if grounded
        //isGrounded = Physics2D.OverlapCircle(groundPoint.position, .2f, whatIsGround);
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

    public void AirAtt(InputAction.CallbackContext ctx)
    {
        Debug.Log("fkfkfkfkf0");
        air_particles.Play();
    }
}
