using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputPortTop : MonoBehaviour {

	public bool correctResistor;
	public GameObject topPort;

	void update(){}

	public void OnTriggerEnter(Collider Other) 
	{
		if (Other.tag == "Resistor") 
		{
			print ("outputporttop dettected");
			correctResistor = true;	
		}
	}
	public void OnTriggerExit (Collider Other)
	{
		correctResistor = false;
	}
}

