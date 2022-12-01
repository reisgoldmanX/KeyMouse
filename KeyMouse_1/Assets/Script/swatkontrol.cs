using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swatkontrol : MonoBehaviour
{
    Animator swat;
    void Start()
    {
        swat = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            swat.SetFloat("hiz",0.4f);
            if (Input.GetKey(KeyCode.LeftShift)&&Input.GetKey(KeyCode.W))
            {
                swat.SetFloat("hiz", 1f);
            }
        }
        else 
        {
            swat.SetFloat("hiz", 0f);
        }
       
    }
}
