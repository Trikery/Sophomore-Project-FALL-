using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float speed = 1;
	private Vector3 tempPosX;
	public GameObject player;

	void Update () {
		tempPosX.x = speed * Time.deltaTime;
		transform.Translate (tempPosX);
	}
}
