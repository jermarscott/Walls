using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    // Our initial timer variable which will store our time.
    float timer = 0;

    void Update()
    {
        // Timer begins counting up from 0.
        timer += Time.deltaTime;
    }

    void LevelFinished()
    {
        // Is the time less than or equal to 20 seconds?
        if (timer >= 20f)
        {
            print("Player get's a bronze star!");
        }
        // Is the time less than or equal to 40 seconds, 
        //but greater than 20 seconds?
        else if (timer >= 40f && timer <=60f)
        {
            print("Player get's a silver star!");
        }
        // Is the time less than or equal to 60 seconds, 
        //but greater than 40 seconds?
        else if (timer >=60f)
        {
            print("Player get's a bronze star!");
        }
        // The timer has counted too far for the player to get a star.
        else
        {
            print("Player get's nothing!");
        }
    }

}
