using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySlot : MonoBehaviour
{
    public GameObject desiredScreen;                                                                          //Screen 2 object that contains the multiple choice system script.  Contains the bool variable effected by the trigger in this script.
    public string keyName;                                                                                    //Makes the tag the script looks for editable from the inspector, allows for this single script to be attached to multiple objects and function correctly

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == keyName)
        {
            var keyinserted = desiredScreen.GetComponent<MultipleChoiceSystem>().keyInserted = true;      //Accesses script on the desired screen and sets the keyInserted bool to true.
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var keyunsinserted = desiredScreen.GetComponent<MultipleChoiceSystem>().keyInserted = false;
    }
}
