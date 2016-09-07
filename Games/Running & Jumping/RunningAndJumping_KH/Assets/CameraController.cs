using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;       

	private Vector3 offset;

	void Start () 
	{
		offset = transform.position - player.transform.position + new Vector3 (0,5,0); // By adding this new Vector3 the Camera isn't looking directly at the player but a short distance above
	}

	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
