using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

	public Transform RabbitArt;

	public bool forward = true;


	void FlipCharacter (KeyCode _keyCode) 
	{
		switch (_keyCode) 
		{
		case KeyCode.RightArrow:
			if (forward) {
				RabbitArt.Rotate (0, 180, 0);
				forward = false;
			}
			break;
		case KeyCode.LeftArrow:
			if (!forward) {
				RabbitArt.Rotate (0, 180, 0);
				forward = true;
			}
			break;
		}
	}

	void Start ()
	{
		RabbitArt = GetComponent<Transform> ();
		UserInputs.UserInput += FlipCharacter; //    Subscribing?
	}

	void OnDestroy () {
		UserInputs.UserInput -= FlipCharacter; //  	 UnSubscribing?
	}
}
