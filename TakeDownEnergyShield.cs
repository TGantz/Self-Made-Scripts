using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDownEnergyShield : MonoBehaviour {
    public GameObject generatorparent;

    private void Update()
    {
        if (generatorparent.gameObject.transform.childCount == 0)
        {
            Destroy(this.gameObject);
        }
    }



}
