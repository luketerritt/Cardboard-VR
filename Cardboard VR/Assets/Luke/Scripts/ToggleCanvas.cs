using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject current, toActivate;
    public void Toggle()
    {
        toActivate.SetActive(true);
        current.SetActive(false);
    }
}
