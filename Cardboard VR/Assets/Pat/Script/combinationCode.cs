using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class combinationCode : MonoBehaviour
{
    public static string correctCode = "5423";
    public static string playerCode = "";

    public static int totalDigits = 0;
    public static int vaultUnlock = 0; 

    public Text combinationText;




    // Update is called once per frame
    void Update()
    {
       // Debug.Log(playerCode); 

        if (totalDigits == 4)
        {
            if (playerCode == correctCode)
            {
                combinationText.color = Color.green;
                Debug.Log("correct! VAULT IS OPEN");
                vaultUnlock = 1; 
                //vault opens animation
            }
            else
            {
                playerCode = "";
                totalDigits = 0;
                Debug.Log("Incorrect!"); 
            }
        }

        combinationText.text = playerCode.ToString(); 
    }

    public void Clickable()
    {
        playerCode += gameObject.name;
        totalDigits += 1; 
    }


}
