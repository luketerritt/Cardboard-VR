using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject toActivate;


    public void TogglePhone()
    {
        toActivate.SetActive(true);
        //current.SetActive(false);

        StartCoroutine(uiPhoneOff());
    }

    private IEnumerator uiPhoneOff ()
    {
        yield return new WaitForSeconds(4);
        toActivate.SetActive(false);
        //current.SetActive(true);       
    }
}
