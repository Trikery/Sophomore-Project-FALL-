using UnityEngine;
using System.Collections;
using System;

public class UserInputs : MonoBehaviour {


	public static Action <KeyCode> JumpButton;
	public static Action <float> MoveWithArrows;

	void Update ()
	{
		if (MoveWithArrows != null)
			MoveWithArrows(Input.GetAxis("Horizontal"));

		if (Input.GetKeyDown (KeyCode.Space) && JumpButton != null) {
			JumpButton (KeyCode.Space);
		}
	}

}
