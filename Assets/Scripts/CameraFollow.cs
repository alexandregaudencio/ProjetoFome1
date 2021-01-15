using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.3f;
    public float OffSetY = 3f;
    
    private Vector3 currentVelocity;

    void LateUpdate()
    {
        float newYCamera = target.position.y + OffSetY;  

        if (newYCamera > transform.position.y) {
           Vector3 newPos = new Vector3 (transform.position.x, newYCamera , transform.position.z );
            transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVelocity, smoothSpeed*Time.deltaTime );
        }
    }
}
