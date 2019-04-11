using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPort : MonoBehaviour {
	public bool correctResistor2;

	void OnTriggerEnter(Collider Other) 
	{
		if (Other.gameObject.tag == "Resistor") 
		{
			correctResistor2 = true;	
		}
	}
	void OnTriggerExit (Collider Other)
	{
		correctResistor2 = false;
	}
}
