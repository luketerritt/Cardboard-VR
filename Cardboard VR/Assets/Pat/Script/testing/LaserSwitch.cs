using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserSwitch : MonoBehaviour
{
    public int maxExplosiveVoltage = 130; //Max 130voltage that can turn OFF laser
    public int securityAlarmVoltage = 90; //Max 90voltage that can turn OFF security alarm

    //starting counter
    private int startVoltage = 0;
    public int totalVoltage = 0;

    //laser Gameobject- to be turned OFF when maxExplosiveVoltage is met.
    GameObject laser;

    public Text text_totalVolts;

    //a list of gameobjects that = maxExplosiveVoltage



    // A list of Cubes that adds up to max voltage



    void Start()
    {
        UpdateVoltage();

    }

    // Update is called once per frame
    void Update()
    {
       // UpdateVoltage();

        //color match; maybe if the gameobject have the same tag/layer, then group it
        //


    }


    public void UpdateVoltage()
    {
        totalVoltage = 0;

        foreach (Transform child in transform)
        {
            if (child.GetComponent<Fuse>() != null)
            {
                totalVoltage += child.GetComponent<Fuse>().voltage;
                //Debug.Log("Total voltage of " + this.gameObject.name + " = " + totalVoltage);
            }
            // update voltage text at top of fuse box

            text_totalVolts.text = totalVoltage.ToString();


        }

    }

}


