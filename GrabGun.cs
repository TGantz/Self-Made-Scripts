using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class GrabGun : MonoBehaviour {

    public Transform rhand;
    public bool canHold = true;
    public GameObject gunHandle;
    public float speed = 10;

    void Update()
    {
        if (SteamVR_Input.GetStateDown("GrabGrip", SteamVR_Input_Sources.RightHand))
        {

      

            if (!canHold)
                throw_drop();
            else
                Pickup();
        } //mause If

        if (!canHold && gunHandle)
            gunHandle.transform.position = rhand.position;

    }//update

    //We can use trigger or Collision
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            if (!gunHandle) // if we don't have anything holding
                gunHandle = col.gameObject;
    }

    //We can use trigger or Collision
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (canHold)
                gunHandle = null;
        }
    }


    private void Pickup()
    {
        if (!gunHandle)
            return;

        //We set the object parent to our guide empty object.
        gunHandle.transform.SetParent(rhand);

        //Set gravity to false while holding it
        gunHandle.GetComponent<Rigidbody>().useGravity = false;

        //we apply the same rotation our main object (Camera) has.
        gunHandle.transform.localRotation = transform.rotation;
        //We re-position the ball on our guide object 
        gunHandle.transform.position = rhand.position;

        canHold = false;
    }

    private void throw_drop()
    {
        if (!gunHandle)
            return;

        //Set our Gravity to true again.
        gunHandle.GetComponent<Rigidbody>().useGravity = true;
        // we don't have anything to do with our ball field anymore
        gunHandle = null;
        //Apply velocity on throwing
        rhand.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;

        //Unparent our ball
        rhand.GetChild(0).parent = null;
        canHold = true;
    }
}

