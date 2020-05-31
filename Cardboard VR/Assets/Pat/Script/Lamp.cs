using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject lightShine; 
    
    
    public void lightOn()
    {
        lightShine.SetActive(true); 
    }
}
