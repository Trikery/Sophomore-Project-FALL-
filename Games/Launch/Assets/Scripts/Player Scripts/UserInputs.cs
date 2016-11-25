using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour {

	public static Action<float> MoveInput;
	public static Action<KeyCode> JumpInput;
	public static Action<KeyCode> ChargeInput;

	void Update ()
	{
		if (Input.GetKey (KeyCode.Space) && ChargeInput != null) {
			ChargeInput (KeyCode.Space);
		}

		if (Input.GetKeyUp (KeyCode.Space) && JumpInput != null) {
			JumpInput (KeyCode.Space);
		}

		if (MoveInput != null){
			MoveInput(Input.GetAxis("Horizontal"));
		}
	}
}