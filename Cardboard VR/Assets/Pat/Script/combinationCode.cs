using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combinationCode : MonoBehaviour
{
    public static string correctCode = "78451";
    public static string playerCode = "";

    public static int totalDigits = 0; 


    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerCode); 

        if (totalDigits == 5)
        {
            if (playerCode == correctCode)
            {
                Debug.Log("correct! VAULT IS OPEN"); 
                //vault opens animation
            }
            else
            {
                playerCode = "";
                totalDigits = 0;
                Debug.Log("Incorrect!"); 
            }
        }
    }

    public void Clickable()
    {
        playerCode += gameObject.name;
        totalDigits += 1; 
    }


}
