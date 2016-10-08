using UnityEngine;
using System.Collections;

public class ClimbPlatform : MonoBehaviour {

	public CharacterMovement character;

	void OnTriggerExit () {
		character.jumpCount = 1;
	}
}
 