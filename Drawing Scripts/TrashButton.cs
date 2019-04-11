using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrashButton : MonoBehaviour
{
    public GameObject rightHand;
    private GameObject[] drawnObjects;

    private void Update()
    {
        drawnObjects = GameObject.FindGameObjectsWithTag("Drawn");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for(var i=0; i<drawnObjects.Length; i++)
            {
                Destroy(drawnObjects[i]);
            }
        }
    }
}

