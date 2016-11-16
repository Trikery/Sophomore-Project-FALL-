using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 2;
	public float gravity = 5;

	public float jumpCharge;
	public float chargeRate;
	public float jumpPower = 10;
	public float chargeMax;

	public CharacterController player;
	private Vector3 movePlayer;

	void Start ()
	{
		player = GetComponent<CharacterController> ();
		UserInputs.MoveWithArrows += Move;
		UserInputs.JumpButton += Jump;
	}

	void Move (float _movex)
	{
		//if (!player.isGrounded) 

		movePlayer.x = _movex * speed * Time.deltaTime;
		movePlayer = transform.TransformDirection (movePlayer * Time.deltaTime);
		print ("moving");
		movePlayer.y = 0;
		player.Move (movePlayer);
		movePlayer.y -= gravity * Time.deltaTime;
	}

	void Jump(KeyCode _keycode)
	{
		movePlayer.y = jumpPower;
		print ("jump");
	}
		
}