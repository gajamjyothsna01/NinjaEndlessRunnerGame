using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Vector2 velocity;
    /*Rigidbody2D rb;
    Animator animator;
    public float playerJumpForce;
    public float playerSpeed;
    SpriteRenderer render;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("isIdle");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            rb.AddForce(Vector2.up * playerJumpForce);
            animator.SetTrigger("isJump");
        }
        float inputX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(inputX * playerSpeed, rb.velocity.y);
        if(inputX > 0 || inputX <0 )
        {
            animator.SetTrigger("isRun");
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("isAttack");

        }
        if(Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("isSlide");
        }
        if(inputX > 0)
        {
            render.flipX = false;
            
        }
        if(inputX < 0)
        {
            render.flipX = true;
        }
    }*/
    public float playerSpeed;
    public float jumpforce;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sprite;
    float xInput;
   // bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("isIdle");
        xInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerJump();
        }

        if (xInput != 0)
        {
            PlayerRun(xInput);
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerSlide();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerAttack();
        }
    }

    private void PlayerAttack()
    {
        animator.SetTrigger("isAttack");
    }

    private void PlayerSlide()
    {
        animator.SetTrigger("isSlide");
    }

    private void PlayerJump()
    {
        rb.AddForce(Vector3.up * jumpforce);
        animator.SetTrigger("isJump");
    }

    private void PlayerRun(float xInput)
    {
        rb.velocity = new Vector2(playerSpeed * xInput, rb.velocity.y);
        if (xInput > 0 || xInput < 0)
        {
            animator.SetTrigger("isRun");
        }
        if (xInput > 0)
        {
            sprite.flipX = false;
        }
        else if (xInput < 0)
        {
            sprite.flipX = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       /* isGrounded = true;
        if (collision.gameObject.tag == "Platform")
        {
            animator.SetTrigger("isJump");
        }*/
        if (collision.gameObject.tag == "Coins")
        {
            Destroy(collision.gameObject);
            GameObject.Find("ScoreManager").GetComponent<ScoreManagerScript>().Score(10);

        }

    }
    //Need to do 



}
