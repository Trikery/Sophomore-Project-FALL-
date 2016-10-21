using UnityEngine;
using System.Collections;

public class ParallaxSymbols : MonoBehaviour {

	public CanvasRenderer rend;
	public float scrollspeed = 0.1f;

	void Start () {
		rend = GetComponent<CanvasRenderer> ();
		rend.GetMaterial ();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
