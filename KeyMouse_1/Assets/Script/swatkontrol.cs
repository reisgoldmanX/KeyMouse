using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swatkontrol : MonoBehaviour
{
    Animator swat;
    float maxspeed;
    float axisZ;
    void Start()
    {
        swat = GetComponent<Animator>();
        Time.timeScale = 0; // Pause Game in the first run
    }

    
    void Update()
    {
        Swat_control();
       
    }
    void Swat_control()
    {
        if (Input.GetKey(KeyCode.W))
        {
            swat.SetFloat("hiz", 0.4f); // WALK Speed
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            {
                swat.SetFloat("hiz", 1f); // Running Speed

                maxspeed = 0.3f;
            }
        }

        else if (Input.GetKey(KeyCode.A))
        {
            // Walk Left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // Walk Right
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Walk Back
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            // crouch and stand still

            
        }
        else
        {

            // Stand still (no movement)
            swat.SetFloat("hiz", 0f);

            swat.SetFloat("hiz", 0f);
            maxspeed = 0f;
            //axisZ = maxspeed * Input.GetAxis("Vertical");

        }
        Vector3 vector = new Vector3(0,0,axisZ);

        // Animasyonlar aras� ge�i�i d�zenler
        swat.SetFloat("hiz", Vector3.ClampMagnitude(vector,1f).magnitude,1, Time.deltaTime);
        swat.SetFloat("hiz", maxspeed);

    }
}
