using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GrenadeLauncherShot : MonoBehaviour {

    public Transform grenadeSpawn;
    public GameObject grenadePrefab;
    public Transform trigger;
    public bool fingerOnTrigger;
    public float grenadeSpeed;

   void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            fingerOnTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            fingerOnTrigger = false;
        }
    }
    // Update is called once per frame
    void Update ()
    {
        if (fingerOnTrigger == true)
        {
            if (SteamVR_Input.GetStateDown("GrabPinch", SteamVR_Input_Sources.RightHand))
            {
                Fire();
            }
        }
	}

    void Fire()
    {
        
        var grenade = (GameObject)Instantiate(grenadePrefab, grenadeSpawn.position, grenadeSpawn.rotation);

        grenade.GetComponent<Rigidbody>().velocity = grenade.transform.forward * grenadeSpeed;
        

       
    }
}
