using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputPortBottom : MonoBehaviour {

	public bool correctResistor;
	public GameObject bottomPort;

	void update(){}

	public void OnTriggerEnter(Collider Other) 
	{
		if (Other.tag == "Resistor") 
		{
			print ("outputportbottom dettected");
			correctResistor = true;	
		}
	}
	public void OnTriggerExit (Collider Other)
	{
		correctResistor = false;
	}
}

