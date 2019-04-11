using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitOpensDoor : MonoBehaviour
{
    //This is the script used to create a voltage divider circuit in the game for one of the circuit design objectives in the game.

    public GameObject inputPort;        //Choose either bottom or top piece of the port as your port for both input and output, I chose bottom for both input and output
    public GameObject outputPort;
    public GameObject batteryCase;      //Choose either terminal as a distance reference, I choose the negative terminal

    private Vector3 inputLocation;      //Locations of the input, output, and battery port to find distance between
    private Vector3 outputLocation;
    private Vector3 batteryLocation;

    public GameObject resistor5000;     //Resistor objects with their assigned resistances
    public GameObject resistor4000;
    public GameObject resistor3000;
    public GameObject resistor2500;
    public GameObject resistor1500;
    public GameObject resistor500;

    public GameObject battery90;        //Battery objects with their assigned voltages
    public GameObject battery120;
    public GameObject battery150;

    private float inputResistance = 0.0f;   //Float variables when a resistor is plugged into
    private float outputResistance = 0.0f;
    private float inputVoltage = 0.0f;

    public float outputVoltage = 0.0f;
    public float outputResistorPower = 0.0f;

    public bool inputResistorInserted = false;
    public bool outputResistorInserted = false;
    public bool batteryInserted = false;

    public Animator doorAnimator;
    public Renderer doorLight;
    public Material baseColor;
    public Material greenEmission;
    public Material[] correctCircuitLight;

    public void Start()
    {

        inputLocation = inputPort.transform.position;
        outputLocation = outputPort.transform.position;
        batteryLocation = batteryCase.transform.position;

        correctCircuitLight[0] = baseColor;
        correctCircuitLight[1] = greenEmission;

    }

    public void Update()
    {

        //Input resistor arguments

        if (Vector3.Distance(resistor5000.transform.position, inputLocation) < 0.8f)
        {

            inputResistorInserted = true;
            inputResistance = 5000.0f;

        }
        else if (Vector3.Distance(resistor4000.transform.position, inputLocation) < 0.8f)
        {

            inputResistorInserted = true;
            inputResistance = 4000.0f;

        }
        else if (Vector3.Distance(resistor3000.transform.position, inputLocation) < 0.8f)
        {

            inputResistorInserted = true;
            inputResistance = 3000.0f;

        }
        else if (Vector3.Distance(resistor2500.transform.position, inputLocation) < 0.8f)
        {

            inputResistorInserted = true;
            inputResistance = 2500.0f;

        }
        else if (Vector3.Distance(resistor1500.transform.position, inputLocation) < 0.8f)
        {

            inputResistorInserted = true;
            inputResistance = 1500.0f;

        }
        else if (Vector3.Distance(resistor500.transform.position, inputLocation) < 0.8f)
        {

            inputResistorInserted = true;
            inputResistance = 500.0f;

        }
        else
        {
            inputResistorInserted = false;
            inputResistance = 0.0f;
        }

        //Ouptut resistor arguments

        if (Vector3.Distance(resistor5000.transform.position, outputLocation) < 0.8f)
        {

            outputResistorInserted = true;
            outputResistance = 5000.0f;

        }
        else if (Vector3.Distance(resistor4000.transform.position, outputLocation) < 0.8f)
        {

            outputResistorInserted = true;
            outputResistance = 4000.0f;

        }
        else if (Vector3.Distance(resistor3000.transform.position, outputLocation) < 0.8f)
        {

            outputResistorInserted = true;
            outputResistance = 3000.0f;

        }
        else if (Vector3.Distance(resistor2500.transform.position, outputLocation) < 0.8f)
        {

            outputResistorInserted = true;
            outputResistance = 2500.0f;

        }
        else if (Vector3.Distance(resistor1500.transform.position, outputLocation) < 0.8f)
        {

            outputResistorInserted = true;
            outputResistance = 1500.0f;

        }
        else if (Vector3.Distance(resistor500.transform.position, outputLocation) < 0.8f)
        {

            outputResistorInserted = true;
            outputResistance = 500.0f;

        }
        else
        {

            outputResistorInserted = false;
            outputResistance = 0.0f;

        }

        //Battery arguments

        if (Vector3.Distance(battery90.transform.position, batteryLocation) < 0.5f)
        {

            batteryInserted = true;
            inputVoltage = 90.0f;

        }

        //Voltage Divider and Power Equations

        outputVoltage = (inputVoltage * outputResistance) / (inputResistance + outputResistance);
        outputResistorPower = (outputVoltage * outputVoltage) / outputResistance;

        if (outputVoltage == 60.0f)
        {

            doorLight.materials = correctCircuitLight;

            if (this.gameObject.tag == "On")
            {
                doorAnimator.SetTrigger("character_nearby");
            }

        }
    }
}
