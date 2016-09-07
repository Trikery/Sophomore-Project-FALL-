using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	//references
	private CharacterController character;
	private Vector3 moveVector;
	//variables
	public float gravity = 1f;
	public float moveSpeed = 10f;
	public float jumpPower = 20f;

	void Start (){
		character = GetComponent<CharacterController> ();  //get access to the CharacterController Component
	}

	void MoveHorizontal (){  //This function will allow the character to move
		moveVector.x = (moveSpeed * Input.GetAxis ("Horizontal"));
		character.Move (moveVector * Time.deltaTime);
	}

	void Update () {

		if (character.isGrounded) { //tests to see if player is falling or not
			if (Input.GetButton ("Jump"))
				moveVector.y = jumpPower; //GO GO GO, MARIO!!

		}
			
		MoveHorizontal (); //calling movement function
		moveVector.y -= gravity;  //the +- inverts the gravity allowing it to be a positive float instead
	}
}
