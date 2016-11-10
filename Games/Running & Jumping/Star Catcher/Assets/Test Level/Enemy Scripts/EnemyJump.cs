using UnityEngine;
using System.Collections;

public class EnemyJump : MonoBehaviour {

	public GameObject parentWolf;
	public Vector3 moveVector;

	public float jumpPower = 8;

	void Start()
	{
		parentWolf = GetComponent<GameObject> ();
	}

	void OnTriggerEnter()
	{
		print ("wolf is jumping");
		moveVector.y = jumpPower;
	}
}
