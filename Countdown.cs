using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Internal countdown timer acting as a hard time limit for the player to complete the game

public class Countdown : MonoBehaviour {

    public float countdownTimer = 1200.0f;

	
	// Update is called once per frame
	void Update ()
    {
        countdownTimer -= Time.deltaTime;

        Debug.Log(countdownTimer);

        if (countdownTimer == 0.0f)
        {
            GameOver();
                
        }
	}

    void GameOver()
    {


    }
}
