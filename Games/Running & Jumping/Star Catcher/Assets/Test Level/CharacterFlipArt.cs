using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

	public Transform CharacterArt;

	public bool forward = true;


	void FlipCharacter (bool _b) 
	{
		CharacterArt.Rotate (0, 180, 0);
		forward = _b;
	}


	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow) && forward)
		{
			FlipCharacter (false);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow) && !forward)
		{
			FlipCharacter (true);
		}
	}
}
