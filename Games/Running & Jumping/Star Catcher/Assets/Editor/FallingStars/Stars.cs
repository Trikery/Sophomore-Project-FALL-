using UnityEngine;
using System.Collections;
using System;

public class Stars : MonoBehaviour {

	public static Action<Transform> SendStar;

	// Use this for initialization
	void Start () {
		GetComponent<MeshRenderer> ().enabled = false;
		SendStar (transform);
	}
}
