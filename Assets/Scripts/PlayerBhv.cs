using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Component "Rigidbody2D" Indispensável pra esse script
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBhv : MonoBehaviour
{

    private Rigidbody2D rigidbody;
    private float HorizontalDirection = 0f;
    public float movementSpeed = 2f;
    float movementAcel = 0.1f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Vector2 velocity = rigidbody.velocity;
    }


    void Update()
    {
    }

    private void FixedUpdate()
    {
        TouchMovement();
        if(!VariableControler.gameStarted)
        {
            startGame();
        }
         else
        {
            TouchMovement();
        }
    }

     void startGame()
    {
        
        if (Input.touchCount > 0)
        {
            Vector2 velocity = rigidbody.velocity;
            if(!VariableControler.gameStarted)
            {
                velocity.y = VariableControler.initialImpulse;
                rigidbody.velocity = velocity;
                VariableControler.gameStarted = true;
            }
        }
        
    }

     void TouchMovement()
    {
        rigMovAcel();
        
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width/2)
            {
                SetMovementDirection(-1);

            }
            else if (touch.position.x > Screen.width/2)
            {

                SetMovementDirection(1);
            }
        } else {
            SetMovementDirection(0);
        }
    }

    float SetMovementDirection(int vectorUnit) {
        return   HorizontalDirection = Mathf.Lerp( HorizontalDirection, vectorUnit, movementAcel);
    }

     void rigMovAcel()
     {
        Vector2 velocity = rigidbody.velocity;
        velocity.x = HorizontalDirection * movementSpeed;
        rigidbody.velocity = velocity;

     }


    //  void OnTriggerEnter2D( Collider2D other) {
    //     if (other.gameObject.tag == "Item") {
    //         Destroy(other.gameObject);
    //         LevelGenerator.spawnItem();
    //     }
    // }

}
