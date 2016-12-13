using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;
	public Vector3 offset;

	IEnumerator CameraFollow(){					//Coroutine #3
		
		transform.position = new Vector3 (0, target.transform.position.y, 0) + offset;
		yield return null;
		StartCoroutine (CameraFollow ());
	}

	void Start (){
		StartCoroutine (CameraFollow ());
	}

}
