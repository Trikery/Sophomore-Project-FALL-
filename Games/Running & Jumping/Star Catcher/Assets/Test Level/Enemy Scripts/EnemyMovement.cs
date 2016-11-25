using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject target;
	public Vector3 tempPos;
	public Transform wolf;

	public bool canFlipWolf = true;

	public float speed = 5;
	public float gravity = 10;
	public float jumpPower = 5;
	 
	void WolfFlipper (){
		if (target.transform.position.x < wolf.transform.position.x && canFlipWolf) {
			wolf.Rotate (0, 180, 0);
			canFlipWolf = false;
		}
		if (target.transform.position.x > wolf.transform.position.x && !canFlipWolf) {
			wolf.Rotate (0,180, 0);
			canFlipWolf = true;
		}
	}

	public IEnumerator WolfMover()
	{
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.transform.position.x, transform.position.y, transform.position.z),   speed*Time.deltaTime);
			yield return new WaitForEndOfFrame ();
			StartCoroutine (WolfMover ());
		//WolfFlipper ();
	}
}
