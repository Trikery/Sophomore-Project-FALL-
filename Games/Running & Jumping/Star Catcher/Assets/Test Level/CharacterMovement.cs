using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	//references
	private CharacterController character;
	private Vector3 moveVector;

	//Animation
	public Animator animateSprite;

	//variables
	public float gravity = 1f;
	public float moveSpeed = 5f;
	public float jumpPower = 12f;
	public int jumpCount = 1;

	//Coroutine for sliding
	public int slideDuration = 50;
	public float slideTime = 0.01f;

	IEnumerator Slide (){
		int durationTemp = slideDuration;
		while (slideDuration > 0) {
			slideDuration--;
			yield return new WaitForSeconds (slideTime);
			moveSpeed = 12;
			print ("sliding");
		}
		slideDuration = durationTemp;
		moveSpeed = 8;
	}

	void Start (){
		character = GetComponent<CharacterController> ();  //get access to the CharacterController Component
	}

	void MoveHorizontal (){  //This function will allow the character to move
		moveVector.x = (moveSpeed * Input.GetAxis ("Horizontal"));
	//	animateSprite.Play ("RabbitRunAnimation");		//This will chanage the animation to the running sprite
		character.Move (moveVector * Time.deltaTime);
	}

	void Update () {
		if ((Input.GetButtonDown("Jump")) && jumpCount > 0){
				moveVector.y = jumpPower;
				jumpCount --;
			}
		if (character.isGrounded)
			jumpCount = 1;

		if (character.isGrounded && Input.GetKey (KeyCode.RightArrow) && Input.GetKeyDown (KeyCode.S))
			StartCoroutine (Slide());
			
		
		MoveHorizontal (); //calling movement function
		moveVector.y -= gravity;  //the +- inverts the gravity allowing it to be a positive float instead
	}
}
