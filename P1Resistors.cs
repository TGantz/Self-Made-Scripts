using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Resistors : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Pistol Bullet")
            {

                Destroy(this.gameObject);

            }
        
    }
}


