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
        Time.timeScale = 0;
    }

    
    void Update()
    {
        Swat_control();
       
    }
    void Swat_control()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            maxspeed = 0.3f;

            axisZ = maxspeed * Input.GetAxis("Vertical");

            //swat.SetFloat("hiz", 0.4f);
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            {
                // swat.SetFloat("hiz", 1f);
                maxspeed = 1f;
                axisZ = maxspeed * Input.GetAxis("Vertical");
            }
        }
        else
        {
            // swat.SetFloat("hiz", 0f);
            maxspeed = 0f;
            axisZ = maxspeed * Input.GetAxis("Vertical");
        }
        Vector3 vector = new Vector3(0,0,axisZ);

        // Animasyonlar arasý geçiþi düzenler
        swat.SetFloat("hiz", Vector3.ClampMagnitude(vector,1f).magnitude,1, Time.deltaTime);
       // swat.SetFloat("hiz", maxspeed);

    }
}
