using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class movimento : MonoBehaviour
{
    public GameObject objeto;
    int corri1;
    int corri2;
    Vector3 correndo;

    void Start()
    {
        correndo = new Vector3 (0f,0f,0f);
    }

   
    void Update()
    {
        if (corri1 == 1)
        {
            correndo.x += 0.01f; 
            objeto.transform.position = correndo;
        }
         if (corri2 == 1)
        {
            correndo.x -= 0.01f; 
            objeto.transform.position = correndo;
        }
    }
    public void correr (int correr)
    {
        corri1 = correr;
    }
    public void correresquerda (int correr2)
    {
        corri2 = correr2;
    }
}
