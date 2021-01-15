using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salvando : MonoBehaviour
{
    int a;
   
    public Text texto;
    void Start()
    {
        
        if (PlayerPrefs.HasKey("salvando"))
        {
            a = PlayerPrefs.GetInt ("salvando");
            texto.text = a.ToString();
        }
        else
        {
            a = 0;
        }
    }

    
    void Update()
    {
        if (a >= 10)
        {
            a = 0; 
               
            
        }
     
    }
    public void textortroca()
    {
        
        a += 1;
        texto.text = a.ToString();
        PlayerPrefs.SetInt ("salvando", a);
        
    }
}
