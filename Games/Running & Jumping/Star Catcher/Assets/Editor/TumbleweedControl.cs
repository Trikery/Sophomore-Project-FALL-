using UnityEngine;
using System.Collections;

public class TumbleweedControl : MonoBehaviour {

	public Rigidbody rigid;
	private Vector3 forceVector;

	public float forceX = -50;

	IEnumerator RunForce (){
		forceVector.x = forceX;
		yield return null; 
	}

	void Start (){
		rigid = GetComponent<Rigidbody> ();
		StartCoroutine (RunForce ());
	}

}
