using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour {

	public static Action<float> MoveInput;						//Delegate #1  Passing Data
	public static Action<KeyCode> JumpInput;					//Delegate #2  Passing Data
	public static Action<KeyCode> ChargeInput;					//Delegate #3  Passing Data

	public static Action MoneyText;								//Delegate #4

	void Update ()												//One Update
	{
		if (Input.GetKey (KeyCode.Space) && ChargeInput != null) {
			ChargeInput (KeyCode.Space);
		}

		if (Input.GetKeyUp (KeyCode.Space) && JumpInput != null) {
			JumpInput (KeyCode.Space);
		}

		if (MoveInput != null){
			MoveInput(Input.GetAxis("Horizontal"));

			MoneyText ();

		}
	}
}