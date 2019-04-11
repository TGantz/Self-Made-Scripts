using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to the Player object in the hierarchy 

public class OpenDoorPosition : MonoBehaviour 
{
	public GameObject doorYouWantOpen;
	public Animator doorAnimator;
	public MeshRenderer doorLight;
	public Material newlight;


	private Vector3 doorposition;
	private Vector3 playerposition;
	private float door2playerdistance;
	private Material[] lightmats;



	void Start()
	{
		doorposition = doorYouWantOpen.transform.position;
		lightmats = doorLight.GetComponent<MeshRenderer> ().materials;
		print (lightmats [1]);
	}

	// Update is called once per frame
	void Update () 
	{
		playerposition = this.gameObject.transform.position;
		door2playerdistance = Vector3.Distance (playerposition, doorposition);

		if (door2playerdistance < 6.0) 
		{
			doorAnimator.SetTrigger ("character_nearby");
			doorLight.GetComponent<MeshRenderer> ().materials[1] = newlight;
		}
		else 
		{
			doorAnimator.ResetTrigger ("character_nearby");
		}

	}
}
