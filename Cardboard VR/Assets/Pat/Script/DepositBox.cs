using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositBox : MonoBehaviour
{
    //correct box opens
    public bool correctBox= true;
    public int keyRecieved = 0;

    //key is activated
    public GameObject key;
    public bool keyCollected;

    //time script
    public GameManager gameManager;
    public int timeReduction; 


    public void CorrectBox()
    {
        correctBox = true;

        if (correctBox)
        {
            //lid opens & player can get the golden key
            key.SetActive(true);
            keyCollected=true;  //key is now visible, the key should now be 'registered' to open the door
        }
        else
        {
            return; 
        }
    }

    public void IncorrectBox()
    {
        correctBox = false;

        if (!correctBox)
        {
            //if an incorrect box is clicked, the time will decrease by 10secs
            gameManager.GetComponent<GameManager>().currentTime -= timeReduction; 
            //will need to add in a RED colour and sound to indicate that the time has been decreased and affected. 
        }
    }
}
