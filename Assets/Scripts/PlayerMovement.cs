using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private bool facingRight;

    public Animator animator;
   
    public float jumpForce;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public float speed = 0f;
    private float move;
    private Rigidbody2D rb;
    private bool isJumping;
   
  

 

    void Start()
    {
       

        facingRight = true;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     
       
        move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        

       
       

       
    }



    void Update()
    {



        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("IsAttacking");

        }






        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;

            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;

        }
        animator.SetFloat("Speed", Mathf.Abs(move));

        if (isGrounded == false)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }



        if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }


        else if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
            }
        }
    
    
