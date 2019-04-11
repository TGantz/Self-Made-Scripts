using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach this script to the trigger object that would cause the any of the doors from the Sci-Fi style pack to open

public class OpenDoor : MonoBehaviour {

	public Animator DoorYouWantOpen;



	void OnTriggerEnter (Collider Other)
	{
		if (Other.gameObject.tag == "Player") 
		{

			DoorYouWantOpen.SetTrigger ("character_nearby");

		} 
	}

	void OnTriggerExit (Collider Other)
	{
		DoorYouWantOpen.ResetTrigger ("character_nearby");
	}
}
