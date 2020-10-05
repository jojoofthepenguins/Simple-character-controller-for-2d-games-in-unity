using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
   
    public float speed;

    public float jump;

    private float move;

    private Rigidbody2D rb;

    private bool isJumping;

    private void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }


   private void Update()
    {
       move = Input.GetAxis("Horizontal");

       rb.velocity = new Vector2(move * speed, rb.velocity.y);
       if (Input.GetButtonDown("Jump") && !isJumping) 
       {
           rb.AddForce(new Vector2(rb.velocity.x, jump));
           isJumping = true;
       } 
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground")) 
        {
            isJumping = false;
        }


      
   
    }

 

}
