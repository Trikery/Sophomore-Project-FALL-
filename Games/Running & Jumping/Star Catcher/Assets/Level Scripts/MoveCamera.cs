using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float speed = 2;
	private Vector3 tempPosX;

	void Update () {
		tempPosX.x = speed * Time.deltaTime;
		transform.Translate (tempPosX);
	}
}
