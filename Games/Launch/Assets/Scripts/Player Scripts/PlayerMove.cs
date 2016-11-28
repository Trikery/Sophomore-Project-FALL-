using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	//references
	public CharacterController character;  //referencing a character controller
	private Vector3 moveVector;				//referencing vector3 component

	//variables
	public 	float	gravity = 40f;
	public 	float	moveSpeed = 10f;
	public 	float 	jumpPower = 2f;
	public 	float 	jumpPowerBase = 2f;
	public	float	jumpPowerMax = 10;

	public bool canJump = true;
	public bool canCharge = true;
	public float chargeRate = .1f;


	void Start (){
		character = GetComponent<CharacterController> (); 

		//subscribing to the UserInputs Script for character control
		UserInputs.MoveInput += Move;
		UserInputs.JumpInput += Jump;
		UserInputs.ChargeInput += Charge;
	}

	//movement function as subscribed to User Input
	void Move (float _moveInX){

		moveVector.x = (moveSpeed * _moveInX);
		character.Move (moveVector * Time.deltaTime);
		moveVector.y -= gravity*Time.deltaTime;

		if (character.isGrounded) {
			canJump = true;
			moveVector.y = 0;
		}
	}

	//jump function as subscribed to User Input
	void Jump (KeyCode _keycode)
	{
		if (canJump) {
			canJump = false;
			canCharge = true;
			moveVector.y = jumpPower;
			print ("jump");
		}
		jumpPower = jumpPowerBase;
		transform.localScale = new Vector3 (1, 1, 1);
	}

	void Charge (KeyCode _keycode)
	{
		if (canCharge) {
			jumpPower += chargeRate * Time.deltaTime;
			transform.localScale = new Vector3 (1 + (jumpPower / 40) , 1 - (jumpPower/40), 1);
			print (jumpPower);
		}
			
		if (jumpPower >= jumpPowerMax) {
			transform.localScale = new Vector3 (1 + (jumpPower / 40) , 1 - (jumpPower/40), 1);
			canCharge = false;
		}
		
	}

	//Public Function used to unsubscribe userInputs upon death
	public void Unsubscribe(){
		UserInputs.MoveInput -= Move;
		UserInputs.JumpInput -= Jump;
	}
}
	