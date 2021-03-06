﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public Camera cam;
    public GameObject onHand;
    public GameObject circuitBoard;
    public GameObject fuseInHand;

    private Ray ray;
    private RaycastHit hit;
    public int maxDistance;



    bool inHands = false;



    // Update is called once per frame
   public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.53f, 0));
            //ray = cam.ScreenPointToRay(Input.mousePosition + new Vector3(0, 0, 0));

            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                if (!inHands)
                {
                    if (hit.collider.gameObject.tag == "fuse")
                    {
                        hit.collider.transform.SetParent(onHand.transform);
                        hit.collider.transform.localPosition = onHand.transform.localPosition;
                        fuseInHand = hit.collider.gameObject;
                        inHands = true;
                        Debug.Log("Hit object named: " + hit.collider.name);
                    }
                }
                else if (inHands)
                {
                    if (hit.collider.gameObject.tag == "Slot")
                    {
                        Debug.Log("Place fuse into circuitboard.");

                        // set parent to circuitboard
                       
                        // put fuse back onto circuitboard
                        fuseInHand.transform.position = hit.point;
                        // reset rotation to 0, 0, 0
                         
                        
                        // empty hand fuse reference
                        inHands = false;
                        fuseInHand.transform.SetParent(circuitBoard.transform);
                        fuseInHand.transform.localScale = new Vector3(0.15f, 0.15f, 0.13f); 
                        fuseInHand.transform.localRotation = Quaternion.identity;
                    }
                }
                Debug.DrawLine(ray.origin, hit.point, Color.red, 1f);
            }
        }
    }
}

