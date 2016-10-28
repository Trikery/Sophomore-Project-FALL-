using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ParallaxSymbols : MonoBehaviour {

	public RawImage uvThing;
	public float scrollSpeed = 0.02f;

	void Start() 
	{
		uvThing = GetComponent<RawImage> ();
	}
	void Update() 
	{
		float offset = Time.time * scrollSpeed;
		uvThing.uvRect = new Rect (offset, 0,1,1);
	}
}
