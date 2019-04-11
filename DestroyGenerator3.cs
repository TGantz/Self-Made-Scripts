using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGenerator3 : MonoBehaviour {

    public bool generator3destroyed;
    public GameObject generatorexplosion;

	// Update is called once per frame
	public void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Grenade")
        {
            generator3destroyed = true;
            var explodeonimpact = (GameObject)Instantiate(generatorexplosion, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
	}
}
