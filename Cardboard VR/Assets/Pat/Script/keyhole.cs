using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyhole : MonoBehaviour
{
    public GameObject depositBoxKey;

    public Transform nextLocation;

    public GameObject player; 


    public void levelPass()
    {
        //if key is held 
        if (depositBoxKey.GetComponent<DepositBox>().keyCollected == true)
        {
            player.transform.position = nextLocation.transform.localPosition;
            depositBoxKey.GetComponent<DepositBox>().key.SetActive(false); 
        }
    }


}
