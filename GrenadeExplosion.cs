using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeExplosion : MonoBehaviour {

    public GameObject explosion;

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        var explodeonimpact = (GameObject)Instantiate(explosion, this.gameObject.transform.position, this.gameObject.transform.rotation);
        Destroy(this.gameObject);
    }
}
