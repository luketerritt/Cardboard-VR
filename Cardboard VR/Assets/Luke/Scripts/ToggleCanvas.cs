using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject toActivate;


    public void Toggle()
    {
        toActivate.SetActive(true);
        //current.SetActive(false);

        StartCoroutine(uiOff());
    }

    private IEnumerator uiOff ()
    {
        yield return new WaitForSeconds(4);
        toActivate.SetActive(false);
        //current.SetActive(true);
        
    }
}
