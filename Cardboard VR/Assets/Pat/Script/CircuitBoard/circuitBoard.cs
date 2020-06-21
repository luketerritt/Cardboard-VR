using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class circuitBoard : MonoBehaviour
{
    public int voltageSuccess = 130; 
    public int totalVoltage=0;
    public Text voltageAmount;

    public GameObject lasers;
    public GameObject nextLocation;

    public GameObject player;



    // Update is called once per frame
    void Update()
    {
        //Debug.Log(totalVoltage);
        Success();
    }

    void Success()
    {
        if (totalVoltage == voltageSuccess && circuitBoard2.totalVoltage == circuitBoard2.securityAlarmSuccess)
        {
            Debug.Log("deactivate laser");
            StartCoroutine(lasersDeactivated());
        }
    }

    private IEnumerator lasersDeactivated()
    {
        yield return new WaitForSeconds(2);
        lasers.SetActive(false);
        yield return new WaitForSeconds(4);
        player.transform.position = nextLocation.transform.localPosition; 

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "fuse")
        {
            //Debug.Log("enetered"); 
            totalVoltage += other.gameObject.GetComponent<Fuse>().voltage;
            voltageAmount.text = totalVoltage.ToString(); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "fuse")
        {
            totalVoltage -= other.gameObject.GetComponent<Fuse>().voltage;
            voltageAmount.text = totalVoltage.ToString();
        }
    }
}

