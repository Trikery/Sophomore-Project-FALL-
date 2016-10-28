using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour {

	public float endTime = 1;

	public float forceDuration = 0.1f;
	private bool canAddForce = true;
	private float force;
	public float forceRange = 50;
	public float torqueRange = 50;

	private Vector3 forceVector;
	private Vector3 torqueVector;
	private Rigidbody rigid;

	void Start ()
	{
		rigid = GetComponent<Rigidbody> ();
		StartCoroutine (RunRandomForce ());
	}

	IEnumerator RunRandomForce()
	{
		while (canAddForce) 
		{
			forceVector.x = Random.Range (-forceRange, forceRange);
			torqueVector.z = Random.Range (-torqueRange, torqueRange); //multiplication is allways faster than division
			rigid.AddTorque (torqueVector);
			rigid.AddForce (forceVector);
			yield return new WaitForSeconds (forceDuration);
		}
	}

	void OnTriggerEnter(){
		StaticPointSystem.starCount++;
		Destroy (this.gameObject);
		print (StaticPointSystem.starCount);

	}

	void OnCollisionEnter () 
	{
		Destroy (gameObject, endTime);  // adding a second parameter would allow for a delay on impact
		canAddForce = false;
		print ("destroyed a star");
	}
}
