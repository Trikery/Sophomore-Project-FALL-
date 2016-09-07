using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	private CharacterController character;
	private Vector3 moveVector;
	public float gravity = 20.0F;
	public float moveSpeed = 6f;
	public float jumpPower = 10f;

	void Start (){
		character = GetComponent<CharacterController> ();
	}

	void MoveHorizontal (float myInput){
		moveVector.x = myInput;
		moveVector = transform.TransformDirection (moveVector * moveSpeed * Time.deltaTime);
		character.Move (moveVector);
	}

	void Update () {

		if (character.isGrounded) {
			moveVector = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			moveVector = transform.TransformDirection(moveVector);
			moveVector *= moveSpeed;
			if (Input.GetButton("Jump"))
				moveVector.y = jumpPower;

		}
			
		MoveHorizontal (Input.GetAxis ("Horizontal"));
		moveVector.y -= gravity * Time.deltaTime;
	}
}
