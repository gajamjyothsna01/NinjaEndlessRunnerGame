using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Vector2 velocity;
    Rigidbody2D rb;
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
            animator.SetTrigger("isJump");
            rb.AddForce(Vector2.up * playerJumpForce);
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
    }
    //Need to do 
    
}
