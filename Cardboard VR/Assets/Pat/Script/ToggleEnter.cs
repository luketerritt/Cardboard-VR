using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEnter : MonoBehaviour
{
    public GameObject Lighttrigger;
    public GameObject batteryInPlace; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Battery"))
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            batteryInPlace.SetActive(true); 
            Lighttrigger.SetActive(true);
        }
    }
}
