using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {



	public CharacterController player;
	public Vector3 movePlayer;

	void Start()
	{
		player = GetComponent<CharacterController> ();

	}



//	void AddCharge ()
//	{
//		if (jumpCharge < chargeMax)
//			jumpCharge += chargeRate;
//	}

}
