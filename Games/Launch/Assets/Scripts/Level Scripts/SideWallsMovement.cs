using UnityEngine;
using System.Collections;

public class SideWallsMovement : MonoBehaviour {

	public Vector3 xTranslate;

	void OnTriggerEnter(Collider other){
		other.gameObject.transform.position = other.gameObject.transform.position + xTranslate;
		
	}
}
