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
	public 	int 	jumpCount = 2;
	public 	int 	jumpMax = 2;

	void Start (){
		character = GetComponent<CharacterController> ();  //get access to the CharacterController Component on this object
		UserInputs.MoveInput += Move;
		UserInputs.JumpInput += Jump;
	}

	//movement function as subscribed to User Input
	void Move (float _moveInX){

		moveVector.x = (moveSpeed * _moveInX);

		if (_moveInX != 0) {
			anim.SetBool ("Running", true);
		} else {
			anim.SetBool ("Running", false);
		}
			
		character.Move (moveVector * Time.deltaTime);

		moveVector.y -= gravity*Time.deltaTime;

		if (character.isGrounded) {
			moveVector.y = 0;
			jumpCount = jumpMax;
		}
	}

	void Jump (KeyCode _keycode)
	{
		if (jumpCount > 0){
			moveVector.y = jumpPower;
			jumpCount --;
		}
	}
}