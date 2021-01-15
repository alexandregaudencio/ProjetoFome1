using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class mouseTouchControl : MonoBehaviour
{
 // for this example, using the actual screen centre as our central point
// change this if you like :)
Vector2 myCentre = new Vector2( Screen.width/2, Screen.height/2 );
Vector2 touchPos = new Vector2( Screen.width/2, Screen.height/2 );

// change this to affect how quickly the number moves toward its destination
float lerpSpeed = 0.3f;

// set this as big or small as you want. I'm using a factor of the screen's size
float deadZone = 0.1f * Mathf.Min( Screen.width, Screen.height );   

public void Update()
{
    Vector2 delta = (Vector2)Input.mousePosition - myCentre;

    // if the mouse is down / a touch is active...
    if( Input.GetMouseButton( 0 ) == true )
    {
        // for the X axis...
        if( delta.x > deadZone )
        {
            // if we're to the right of centre and out of the deadzone, move toward 1
            touchPos.x = Mathf.Lerp( touchPos.x, 1, lerpSpeed );
        }
        else if( delta.x < -deadZone )
        {
            // if we're to the left of centre and out of the deadzone, move toward -1
            touchPos.x = Mathf.Lerp( touchPos.x, -1, lerpSpeed );
        }
        else
        {
            // otherwise, we're in the deadzone, move toward 0
            touchPos.x = Mathf.Lerp( touchPos.x, 0, lerpSpeed );
        }

        // repeat for the Y axis...
        if( delta.y > deadZone )
        {
            touchPos.y = Mathf.Lerp( touchPos.y, 1, lerpSpeed );
        }
        else if( delta.y < -deadZone )
        {
            touchPos.y = Mathf.Lerp( touchPos.y, -1, lerpSpeed );
        }
        else
        {
            touchPos.y = Mathf.Lerp( touchPos.y, 0, lerpSpeed );
        }
    }
    else
    {
        // the mouse is up / no touch recorded, so move both axes toward 0
        touchPos.x = Mathf.Lerp( touchPos.x, 0, lerpSpeed );
        touchPos.y = Mathf.Lerp( touchPos.y, 0, lerpSpeed );
    }

    Debug.Log("TouchPos: " + touchPos );


}

}
