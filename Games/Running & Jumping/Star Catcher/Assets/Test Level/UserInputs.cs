using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour {

	public static Action<KeyCode> UserInput;
	public static Action<float> MoveInput;
	public static Action<KeyCode> JumpInput;
	public static Action<KeyCode> PauseInput;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.RightArrow) && UserInput != null) {
			UserInput (KeyCode.RightArrow);
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow) && UserInput != null) {
			UserInput (KeyCode.LeftArrow);
		}

		if (Input.GetKeyDown (KeyCode.Space) && UserInput != null) {
			JumpInput (KeyCode.Space);
		}

		if (MoveInput != null){
			MoveInput(Input.GetAxis("Horizontal"));
		}
		if (Input.GetKeyDown (KeyCode.Return) && UserInput != null) {
			JumpInput (KeyCode.Return);
		}
	}
}