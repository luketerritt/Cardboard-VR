using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    public int voltage = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CircuitBoard")
        {
            this.gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
        } 
    }
}
