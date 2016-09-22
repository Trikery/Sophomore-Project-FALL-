using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 tempPos;

	void Start () 
	{
		tempPos = player.transform.position; // By adding this new Vector3 the Camera isn't looking directly at the player but a short distance above
	}

	void LateUpdate () 
	{
		tempPos.y = player.transform.position.y;
	}
}
