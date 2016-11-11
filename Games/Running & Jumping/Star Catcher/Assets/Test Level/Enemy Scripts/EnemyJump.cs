using UnityEngine;
using System.Collections;

public class EnemyJump : MonoBehaviour {

	public GameObject wolfParent;
	public float jumpPower = 10;

	void OnTriggerEnter()
	{
		wolfParent.transform.Translate (0, jumpPower, 0);
		print ("wolf is jumping");
	}

}
