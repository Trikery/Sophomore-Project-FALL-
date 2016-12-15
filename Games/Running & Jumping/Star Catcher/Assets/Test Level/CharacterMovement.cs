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

	public AudioClip footSteps;
	public AudioClip rabbitJumpSound;
	public AudioSource source;
	public float stepRate;
	public float pitchMin = 0.5f;
	public float pitchMax = 1.5f;
	bool canStep = true;

	IEnumerator FootStepSounds(){
		source.clip = footSteps;
		source.pitch = Random.Range (pitchMin, pitchMax);
		source.Play ();
		yield return new WaitForSeconds(stepRate);
		canStep = true;
	}

	void JumpSound (){
		source.clip = rabbitJumpSound;
		source.PlayOneShot (rabbitJumpSound);

	}

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
			anim.SetBool ("Landing", true);
			moveVector.y = 0;
			jumpCount = jumpMax;
		}

		if (character.isGrounded && character.velocity.magnitude > 0.3 && canStep) {
			canStep = false;
			StartCoroutine (FootStepSounds ());
		}
	}

	void Jump (KeyCode _keycode)
	{
		anim.SetBool ("Landing", false);
		if (jumpCount == jumpMax)
			anim.Play ("RabbitJumpPrep");

		if (jumpCount > 0){
			if (jumpCount <= jumpMax-1)
				anim.Play ("RabbitJumping");
			moveVector.y = jumpPower;
			JumpSound ();
			jumpCount --;
		}
	}

	public void Unsubscribe(){
		UserInputs.MoveInput -= Move;
		UserInputs.JumpInput -= Jump;
	}
}