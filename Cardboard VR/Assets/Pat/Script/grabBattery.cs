using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabBattery : MonoBehaviour
{
    public GameObject battery;
    public GameObject myHand;
    public float handPower;

    // public GameObject boxesTranform; 

    bool inHands = false;
    bool colDestroy = false;

    Collider battCol;
    Rigidbody battRb;
    Camera cam;


    void Start()
    {
        battCol = battery.GetComponent<CapsuleCollider>();
        battRb = battery.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                battCol.isTrigger = true;
                battery.transform.SetParent(myHand.transform);
                battery.transform.localPosition = myHand.transform.localPosition;
                battRb.useGravity = false;
                inHands = true;
            }
            else if (inHands)
            {
                Debug.Log("released");
                battCol.isTrigger = false;
                battRb.useGravity = true;
                battery.transform.SetParent(null);
                battRb.velocity = cam.transform.rotation * Vector3.forward * handPower;
                inHands = false;
            }
        }
    }
}
