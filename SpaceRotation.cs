using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Used this to create a rotation on the skybox, which gives a sense that the environment is moving.  Control the speed of rotation in the Inspector


public class SpaceRotation : MonoBehaviour 
{
	public float speedMultiplier;
	
	// Update is called once per frame
	void Update () 
	{
		this.gameObject.transform.Rotate(0,speedMultiplier*Time.deltaTime,0);  
	}
}
