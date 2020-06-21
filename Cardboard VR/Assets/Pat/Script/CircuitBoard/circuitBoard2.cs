using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class circuitBoard2 : MonoBehaviour
{
    public static int securityAlarmSuccess = 90;

    public static int totalVoltage = 0;

    public Text securityAmountUI;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(totalVoltage);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "fuse")
        {
            //Debug.Log("entered");
            totalVoltage += other.gameObject.GetComponent<Fuse>().voltage;
            securityAmountUI.text = totalVoltage.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "fuse")
        {
            totalVoltage -= other.gameObject.GetComponent<Fuse>().voltage;
            securityAmountUI.text = totalVoltage.ToString();
        }
    }
}
