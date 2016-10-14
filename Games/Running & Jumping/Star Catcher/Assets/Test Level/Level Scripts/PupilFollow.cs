using UnityEngine;
using System.Collections;

public class PupilFollow : MonoBehaviour {

	public GameObject player;
	public Vector3 tempPos;
	public float speed = 0.5f;

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position,   speed*Time.deltaTime);

	}
}
