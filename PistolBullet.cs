using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    { 
        Destroy(this.gameObject);
    }
}


