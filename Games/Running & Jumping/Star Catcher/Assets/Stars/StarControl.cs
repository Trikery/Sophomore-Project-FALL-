using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour {


	public float endTime = 2;

	public float forceDuration = 0.1f;
	private bool canAddForce = true;
	private float force;
	public float forceRange = 50;
	//public float torqueRange = 50;

	private Vector3 forceVector;
	//private Vector3 torqueVector;
	private Rigidbody rigid;

	void Start ()
	{
		rigid = GetComponent<Rigidbody> ();
		StartCoroutine (RunRandomForce ());
	}

	IEnumerator RunRandomForce()
	{
		forceVector.x = Random.Range (-forceRange, forceRange);
		//torqueVector.z = Random.Range (-torqueRange, torqueRange); //multiplication is allways faster than division
		while (canAddForce) 
		{
			//rigid.AddTorque (torqueVector);
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
		canAddForce = false;
		Destroy (gameObject, endTime);  // adding a second parameter would allow for a delay on impact
		print ("destroyed a star");
	}
}