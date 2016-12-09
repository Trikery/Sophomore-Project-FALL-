using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour {


	public float endTime = 2;

	public float forceDuration = 0.1f;
	private bool canAddForce = true;
	private float force;
	public float forceRange = 50;

	private Vector3 forceVector;
	private Rigidbody rigid;

	public StarBoostText textEffect;
	public ParticleSystem particles;

	public AudioClip audioStart;
	public AudioClip audioCollide;

	void Start ()
	{
		textEffect = GetComponent<StarBoostText> ();
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
		//print (StaticPointSystem.starCount);
	 	textEffect.StarBoost ("+1", Color.white);

	}

	void OnCollisionEnter () 
	{
		
		canAddForce = false;
		particles.maxParticles = 5;
		Destroy (gameObject, endTime);  // adding a second parameter would allow for a delay on impact
		//print ("destroyed a star");
	}
}