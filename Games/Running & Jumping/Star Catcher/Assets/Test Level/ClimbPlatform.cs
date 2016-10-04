using UnityEngine;
using System.Collections;

public class ClimbPlatform : MonoBehaviour {

	public GameObject characterController;
	public Vector3 tempClimb;

	void OnTriggerExit (Collider other) {

		tempClimb.y = 1;
		CharacterMovement.jumpCount = 0;


		
	}
}
