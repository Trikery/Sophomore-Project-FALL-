using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public GameObject target;
	public Vector3 tempPos;
	public Transform wolf;
	public Animator wolfAnim;

	public bool canFlipWolf = true;

	public float speed = 5;
	public float gravity = 10;
	public float jumpPower = 5;

	public AudioSource source;
	public AudioClip[] wolfSteps;
	public float stepRate;
	bool canStep = true;
	 
	IEnumerator FootStepSounds(){
		source.clip = wolfSteps[Random.Range(0, wolfSteps.Length)];
		source.Play ();
		yield return new WaitForSeconds(stepRate);
		canStep = true;
	}

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

	void OnCollisionEnter (){
		wolfAnim.Play ("WolfJumpLand");
	}

	void OnCollisionStay(){
		if (canStep) {
			canStep = false;
			StartCoroutine (FootStepSounds ());
		}
	}

}
