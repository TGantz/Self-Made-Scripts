using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HUDVisibility : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject HUD;
    public GameObject nonRenderedObjects;
    public Renderer[] HUDRenderers;
    
    public bool test = false;
    public float leftHandZRotation;

    void Start()
    {
        Renderer[] HUDRenderers = HUD.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in HUDRenderers)
        {
            r.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        leftHandZRotation = leftHand.transform.localEulerAngles.z;

        Renderer[] HUDRenderers = HUD.GetComponentsInChildren<Renderer>();

        if (leftHandZRotation > 200f && leftHandZRotation < 250f)
        {
            nonRenderedObjects.SetActive(true);
            foreach(Renderer r in HUDRenderers)
            {
                r.enabled = true;
            }  
        }
        else
        {
            nonRenderedObjects.SetActive(false);
            foreach (Renderer r in HUDRenderers)
            {
                r.enabled = false;
            }
        }

    }
}
