using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q2KeySlot : MonoBehaviour
{
    public GameObject screen2;                                                                          //Screen 2 object that contains the multiple choice system script.  Contains the bool variable effected by the trigger in this script.


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Q2 Key")
        {
            var q2keyinserted = screen2.GetComponent<MultipleChoiceSystem>().keyInserted = true;      //Accesses script on Screen 2 and sets the q2keyinserted bool to true.
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var q2keyunsinserted = screen2.GetComponent<MultipleChoiceSystem>().keyInserted = false;
    }
}
