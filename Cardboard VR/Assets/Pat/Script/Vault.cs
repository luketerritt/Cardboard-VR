using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vault : MonoBehaviour
{
    //play animation





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(combinationCode.vaultUnlock == 1)
        {
            Animation();
        }        
    }

   public  void Animation()
    {
        // opening vault door animation; 
        StartCoroutine(Ending());
    }

    IEnumerator Ending()
    {
        yield return new WaitForSeconds(2);
        //man shoots 
        //player flies
        Debug.Log("player flies"); 

    }
}
