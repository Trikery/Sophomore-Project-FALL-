using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour {

	public static Action<float> MoveInput;
	public static Action<KeyCode> JumpInput;

	void Update ()
	{
		if (Input.GetKey (KeyCode.Space) && JumpInput != null) {
			JumpInput (KeyCode.Space);
		}

		if (MoveInput != null){
			MoveInput(Input.GetAxis("Horizontal"));
		}
	}
}