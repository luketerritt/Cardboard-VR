﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{

    //Text properties
    //public Text playerHealth = null;
    //public Text playerAmmo = null;

    public Text timeTime = null;
    
    //Time count down
    public float currentTime = 0f;
    public float startingTime= 10f; 



    private void Start()
    {
        currentTime = startingTime; 

    }
    void Update()
    {
       // displayProperties();
        counter();
        //restartgame();
    }

    //void displayProperties()
    //{
    //    playerHealth.text = "Health:" + player.health.ToString();

    //    if (player.health <= 0)
    //    {
    //        playerHealth.text = "Health:" + player.health.ToString("0");
    //    }    
    //    playerAmmo.text = "Vision Switch:" + ammo.ammos.ToString();  
    //}


    void counter()
    {
        currentTime -= 1 *Time.deltaTime;
        timeTime.text = currentTime.ToString("00:00");    
        
        if(currentTime <= 0)
        {
            currentTime = 0; 
        }
    }

    //void restartgame()
    //{
    //    if (player.health <= 0 || currentTime == 0)
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //        ScoringSystem.honeyScore = 0; 
    //    }
    //}

}


