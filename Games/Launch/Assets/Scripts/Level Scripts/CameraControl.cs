using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;
	public Vector3 offset;

	IEnumerator CameraFollow(){
		
		transform.position = target.transform.position + offset;
		yield return null;
		StartCoroutine (CameraFollow ());
	}

	void Start (){
		StartCoroutine (CameraFollow ());
	}

}
