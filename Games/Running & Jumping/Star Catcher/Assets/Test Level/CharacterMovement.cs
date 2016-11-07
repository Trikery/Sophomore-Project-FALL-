using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	//references
	private CharacterController character;  //referencing a character controller
	private Vector3 moveVector;				//referencing vector3 component

	//Animation
	public	Animator anim;					//referencing an Animator

	//variables
	public 	float	gravity = 40f;
	public 	float	moveSpeed = 10f;
	public 	float 	jumpPower = 14f;
	public 	int 	jumpCount = 1;

	void Start (){
		character = GetComponent<CharacterController> ();  //get access to the CharacterController Component on this object
	}

	//movement function
	void MoveHorizontal (){
			moveVector.x = (moveSpeed * Input.GetAxis ("Horizontal"));
		if (Input.GetAxis ("Horizontal") != 0) {
			anim.SetBool ("Running", true);
		} else {
			anim.SetBool ("Running", false);
		}
		character.Move (moveVector * Time.deltaTime);
	}


	void Update () {
		//jump/double jump command
		if ((Input.GetButtonDown("Jump")) && jumpCount > 0){
			
				moveVector.y = jumpPower;
				jumpCount --;
			}

		//double jump variable reset
		if (character.isGrounded)
			jumpCount = 1;
		
		//calling movement function
		MoveHorizontal ();

		//creating a gravity effect
		moveVector.y -= gravity*Time.deltaTime;  //the +- inverts the gravity allowing it to be a positive float instead

		if (character.isGrounded) {
			moveVector.y = 0;
		}
	//	print (character.velocity);
	}
}
