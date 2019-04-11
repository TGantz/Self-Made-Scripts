using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchControls : MonoBehaviour
{
    public GameObject clockScreen;
    public GameObject multimeterScreen;
    public GameObject resistorBandChart;



    // Update is called once per frame
    void Update()
    {

        if(this.gameObject.tag == "Clock")
        {
            resistorBandChart.SetActive(false);
        }
        if(this.gameObject.tag == "Multimeter")
        { 
            resistorBandChart.SetActive(false);
        }
        if (this.gameObject.tag == "Resistor Chart")
        {
            resistorBandChart.SetActive(true);
        }
    }
}
