using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	//references
	private CharacterController character;
	private Vector3 moveVector;
	//variables
	public float gravity = 1f;
	public float moveSpeed = 10f;
	public float jumpPower = 10f;
	public int jumpCount = 2;

	void Start (){
		character = GetComponent<CharacterController> ();  //get access to the CharacterController Component
	}

	void MoveHorizontal (){  //This function will allow the character to move
		moveVector.x = (moveSpeed * Input.GetAxis ("Horizontal"));
		character.Move (moveVector * Time.deltaTime);
	}

	void Update () {
		if ((Input.GetButtonDown("Jump")) && jumpCount > 0){
				moveVector.y = jumpPower;
				jumpCount --;
			}
		if (character.isGrounded)
			jumpCount = 2;
		
		MoveHorizontal (); //calling movement function
		moveVector.y -= gravity;  //the +- inverts the gravity allowing it to be a positive float instead
	}
}
