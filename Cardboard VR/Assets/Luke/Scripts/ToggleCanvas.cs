﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject toActivate;

  

    public void TogglePhone()
    {
        toActivate.SetActive(true);
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        //current.SetActive(false);

        //StartCoroutine(uiPhoneOff());
    }

    //private IEnumerator uiPhoneOff ()
    //{
    //    yield return new WaitForSeconds(2);
    //    toActivate.SetActive(false);
    //    //current.SetActive(true);       
    //}

}
