using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class Pistol : MonoBehaviour
{

    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public GameObject pistolTrigger;
    public GameObject Hand;
    public bool fingerOnTrigger=false;
    public float bulletSpeed;
    AudioSource pistolShotSound;

    private float pistolAmmo;
    public Text pistolAmmoText;

    private Vector3 handPosition;
    private Vector3 triggerPosition; 
    public float handToTriggerDistance;

    void Start()
    {
        pistolShotSound = GetComponent<AudioSource>();
        pistolAmmo = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        handPosition = Hand.transform.position;
        triggerPosition = pistolTrigger.transform.position;

        handToTriggerDistance = Vector3.Distance(handPosition,triggerPosition);

        if (handToTriggerDistance < .06f)
        {
            fingerOnTrigger = true;
        }

        pistolAmmoText.text = pistolAmmo.ToString();

        print(handToTriggerDistance);

        if (pistolAmmo > 0.0f)
        {
            if (fingerOnTrigger == true)
            {
                if (SteamVR_Input.GetStateDown("GrabPinch", SteamVR_Input_Sources.RightHand))
                {
                    Fire();
                }
            }
        }
    }

    void Fire()
    {

        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * bulletSpeed;

        pistolShotSound.Play();

        pistolAmmo -= 1.0f;

    }
}