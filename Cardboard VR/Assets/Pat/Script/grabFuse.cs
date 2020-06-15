using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabFuse : MonoBehaviour
{
    //public LaserSwitch Fusebox1;
    //public LaserSwitch Fusebox2;
    public List<GameObject> objects = new List<GameObject>();
    // public GameObject fuse;
    public GameObject myHand;

    bool inHands = false;
    Vector3 fusePos;

    Ray ray; 
    RaycastHit hit; 

    void Start()
    {
        foreach (GameObject i in objects)
        {
            fusePos = i.transform.position;
        }
    }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (!inHands)
                {
                    foreach (GameObject i in objects)
                    {
                        i.transform.SetParent(myHand.transform);
                        i.transform.localPosition = myHand.transform.localPosition;
                        inHands = true;
                        //Fusebox1.UpdateVoltage();
                        //Fusebox2.UpdateVoltage();
                    }
                }
                else if (inHands) // how to make it stick to whatever its pointing out to?
                {
                    foreach (GameObject i in objects)
                    {
                        this.GetComponent<grabFuse>().enabled = false;
                        i.transform.SetParent(null);
                        i.transform.localPosition = fusePos;
                        inHands = false;
                        //Fusebox1.UpdateVoltage();
                        //Fusebox2.UpdateVoltage();
                    }

                }
            }
        }
 }



