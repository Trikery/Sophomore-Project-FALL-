using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject player;
	public Vector3 tempPos;

	public float speed = 5;
	public float gravity = 10;

	IEnumerator WolfMover()
	{
			transform.position = Vector3.MoveTowards(transform.position, player.transform.position,   speed*Time.deltaTime);
			yield return new WaitForEndOfFrame ();
		tempPos.y -= gravity*Time.deltaTime;
			StartCoroutine (WolfMover ());
	}

	void Start()
	{
		StartCoroutine (WolfMover ());
	}

}
