using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultimeterScript : MonoBehaviour
{

    public string measuredResistance;
    private string measuredVoltage;
    public Text multimeterReading;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Untagged")
        {
            multimeterReading.text = "Insert Resistor";
        }
        measuredResistance = other.gameObject.tag;
        multimeterReading.text = measuredResistance;
    }

    private void OnTriggerExit(Collider other)
    {
        multimeterReading.text = "Insert Resistor";
    }
}
