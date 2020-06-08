using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaultToggle : MonoBehaviour
{
    public GameObject numberPad;

    public void ToggleOn()
    {
        numberPad.SetActive(true);     
    }
}
