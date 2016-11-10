using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject player;
	public Vector3 tempPos;
	public Transform wolf;

	public bool canFlipWolf = true;

	public float speed = 5;
	public float gravity = 10;

	void WolfFlipper (){
		if (player.transform.position.x < wolf.transform.position.x && canFlipWolf) {
			wolf.Rotate (0, 180, 0);
			canFlipWolf = false;
		}
		if (player.transform.position.x > wolf.transform.position.x && !canFlipWolf) {
			wolf.Rotate (0,180, 0);
			canFlipWolf = true;
		}
	}

	IEnumerator WolfMover()
	{
		transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, transform.position.y, transform.position.z),   speed*Time.deltaTime);
			yield return new WaitForEndOfFrame ();
			StartCoroutine (WolfMover ());
		WolfFlipper ();
	}

	void Start()
	{
		StartCoroutine (WolfMover ());
	}

}
