using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
private Rigidbody2D rb;
private Collider2D col;
public float speed;
private float InputX;
public float Force;
public bool isGrounded;
 private Animator anim;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        isGrounded = true;
    }


    void Update()
    {

    InputX = Input.GetAxisRaw("Horizontal");
    rb.velocity = new Vector2(InputX * speed , rb.velocity.y);  
      if (isGrounded){
      if (Input.GetKeyDown("space"))
    {
        rb.AddForce(transform.up * Force);
        anim.SetTrigger("isJumping");
    }
    if (Input.GetAxisRaw("Horizontal") != 0 )
         {
         anim.SetBool("isRunning", true );
         }
         else 
         {
              anim.SetBool("isRunning", false);
         }
             if (Input.GetAxisRaw("Horizontal") < 0 )
             {
                  transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
             }
             if (Input.GetAxisRaw("Horizontal") > 0 )
             {
             transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

             }
      }
      Debug.Log(Input.GetAxisRaw("Horizontal")) ;  
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
                    anim.SetBool("isGrounded", false);

    } 
        private void OnCollisionEnter2D(Collision2D collision)
        {
            isGrounded = true;
            anim.SetBool("isGrounded", true);
        }

        private void FixedUptade()
        {
            
        }

}
