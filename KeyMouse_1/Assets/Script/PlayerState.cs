using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public int Ammo;
    public int Health;

    public Text Health_text;
    public Text Ammo_text;
    GameObject Gun;

    
    // Start is called before the first frame update
    void Start()
    {
        
        Ammo = 30;
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0))
        {
            if (Ammo <= 0)
            {
                // Reload
                Ammo = 30;
            }
            else
            {
                Ammo -= 1;
                Ammo_text.text = Ammo.ToString();
            }


        }
        Health_text.text = Health.ToString();
    }
}
