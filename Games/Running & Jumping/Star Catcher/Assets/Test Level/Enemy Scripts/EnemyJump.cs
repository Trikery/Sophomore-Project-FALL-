using UnityEngine;
using System.Collections;

public class EnemyJump : MonoBehaviour {

	public EnemyMovement wolf;

	public float jumpPower = 2;

	void OnTriggerEnter()
	{
		wolf.Jump ();
		print ("wolf is jumping");
	}
}
