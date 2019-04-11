using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float playerHealth;
    public float maxHealth;
    public Text healthText;

    void Start()
    {   
        playerHealth = maxHealth;
    }

    
    void Update()
    {
        healthText.text = "Health: " + playerHealth.ToString();         //Health displayed on HUD

        if(playerHealth>maxHealth)
        {
            playerHealth = 100.0f;                                      //Caps health at 100
        }
    }
}
