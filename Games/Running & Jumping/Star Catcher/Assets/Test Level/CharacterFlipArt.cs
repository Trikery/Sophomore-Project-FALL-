﻿using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

	public Transform CharacterArt;
	public bool forward = true;


	void FlipCharacter (KeyCode _keyCode) 
	{
		switch (_keyCode) 
		{
		case KeyCode.RightArrow:
			if (forward) {
				CharacterArt.Rotate (0, 180, 0);
				forward = false;
			}
			break;
		case KeyCode.LeftArrow:
			if (!forward) {
				CharacterArt.Rotate (0, 180, 0);
				forward = true;
			}
			break;
		}
	}

	void Start ()
	{
		CharacterArt = GetComponent<Transform> ();
		UserInputs.UserInput += FlipCharacter; //    ????????
	}
}
