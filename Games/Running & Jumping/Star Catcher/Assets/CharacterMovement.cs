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

	//Coroutine for sliding
	public int slideDuration = 100;
	public float slideTime = 0.01f;

	IEnumerator Slide (){
		int durationTemp = slideDuration;
		while (slideDuration > 0) {
			slideDuration--;
			yield return new WaitForSeconds (slideTime);
			moveSpeed *= 20;
			print ("sliding");
		}
		slideDuration = durationTemp;
		moveSpeed -= 10;
	}

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

		if (character.isGrounded && Input.GetKey (KeyCode.RightArrow) && Input.GetKeyDown (KeyCode.S))
			StartCoroutine (Slide());
			
		
		MoveHorizontal (); //calling movement function
		moveVector.y -= gravity;  //the +- inverts the gravity allowing it to be a positive float instead
	}
}
