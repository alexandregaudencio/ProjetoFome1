using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBhv : MonoBehaviour
{
    public float jumpForce = 8f;



    void OnCollisionEnter2D (Collision2D collision) {
        //SE ESTÁ CAINDO
        if (collision.relativeVelocity.y <= 0f) {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null) {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce; 
                rb.velocity = velocity;
            }
        }
        
        

    }


}
