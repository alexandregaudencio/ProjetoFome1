using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Component "Rigidbody2D" Indispensável pra esse script
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBhv : MonoBehaviour
{

    private Rigidbody2D rigidbody;
    private float directionH = 0f;
    public float movementSpeed = 2f;

    int esquerda;
    int direita;
    int comecar = 0;


    private bool touched = false;

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
        // if (comecar == 1)
        // {
        //     Vector2 velocity = rigidbody.velocity;
        //     velocity.y = VariableControler.initialImpulse;
        //     rigidbody.velocity = velocity;
        //     VariableControler.gameStarted = true;

        // }



        
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
        Debug.Log(Input.touchCount);

        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
             if (touch.position.x < Screen.width/2)
                {
                    directionH = -1f;
                    
                }

                else if (touch.position.x > Screen.width/2)
                {
                    directionH = 1f;
                    

                }
            // if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved )
            // {
            //     if (touch.position.x < Screen.width/2)
            //     {
            //         directionH = -1f;
                    
            //     }

            //     else if (touch.position.x > Screen.width/2)
            //     {
            //         directionH = 1f;
                    
            //     }
            // }
            // if (touch.phase == TouchPhase.Ended)
            // {

            //     directionH = 0f;
                
            // }
        } else {
            directionH = 0f;
        }
      

    }

     void rigMovAcel()
     {
         Vector2 velocity = rigidbody.velocity;
         velocity.x = directionH * movementSpeed;
         rigidbody.velocity = velocity;

     }


    //  void OnTriggerEnter2D( Collider2D other) {
    //     if (other.gameObject.tag == "Item") {
    //         Destroy(other.gameObject);
    //         LevelGenerator.spawnItem();
    //     }
    // }


//apaga não, por hora...  -> (APAGA NAO DEPOIS PODE SERVIR DE CONSULTA PRA OUTROS PROJETOS :) )
// touchPos.y = Mathf.Lerp( touchPos.y, 1, lerpSpeed );




}
