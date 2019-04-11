using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
public class DrawingScript : MonoBehaviour
{

    private GameObject ink;
    public float drawRate;
    private float lastDrawn;
    public bool drawModeOn = false;

    public GameObject redInk;
    public GameObject orangeInk;
    public GameObject yellowInk;
    public GameObject greenInk;
    public GameObject blueInk;
    public GameObject purpleInk;

    public bool redOn = true;
    public bool orangeOn = false;
    public bool yellowOn = false;
    public bool greenOn = false;
    public bool blueOn = false;
    public bool purpleOn = false;
    public bool eraserOn = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Drawn")
        {
            if (drawModeOn == true)
            {
                if(eraserOn == true)
                { 
                    if (SteamVR_Input.GetState("GrabPinch", SteamVR_Input_Sources.RightHand))
                    {
                        Destroy(other);
                    }
                }
            }
        }
    }

    void Update()
    {
        if(redOn == true)
        {
            ink = redInk;
        }
        if(orangeOn == true)
        {
            ink = orangeInk;
        }
        if (yellowOn == true)
        {
            ink = yellowInk;
        }
        if (greenOn == true)
        {
            ink = greenInk;
        }
        if (blueOn == true)
        {
            ink = blueInk;
        }
        if (purpleOn == true)
        {
            ink = purpleInk;
        }

        if(eraserOn == false)
        { 
            if (drawModeOn == true)
            { 
                if (SteamVR_Input.GetState("GrabPinch", SteamVR_Input_Sources.RightHand))
                {
                    if (Time.time - lastDrawn > 1 / drawRate)
                    { 
                        lastDrawn = Time.time;
                        Instantiate(ink, this.gameObject.transform.position, this.gameObject.transform.rotation);
                    }
                }
            }
        }
    }
}
