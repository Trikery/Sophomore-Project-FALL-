using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	//references
	public CharacterController character;  //referencing a character controller
	private Vector3 moveVector;				//referencing vector3 component

	//variables
	public 	float	gravity = 10f;
	public 	float	moveSpeed = 10f;
	public 	float 	jumpPower = 10f;

	void Start (){
		character = GetComponent<CharacterController> (); 

		//subscribing to the UserInputs Script for character control
		UserInputs.MoveInput += Move;
		UserInputs.JumpInput += Jump;
	}

	//movement function as subscribed to User Input
	void Move (float _moveInX){

		moveVector.x = (moveSpeed * _moveInX);
		character.Move (moveVector * Time.deltaTime);
		moveVector.y -= gravity*Time.deltaTime;

		if (character.isGrounded) {
			moveVector.y = 0;
		}
	}

	//jump function as subscribed to User Input
	void Jump (KeyCode _keycode)
	{
			//moveVector.y = jumpPower;
			print ("jump");
	}

	//Public Function used to unsubscribe userInputs upon death
	public void Unsubscribe(){
		UserInputs.MoveInput -= Move;
		UserInputs.JumpInput -= Jump;
	}
}
	