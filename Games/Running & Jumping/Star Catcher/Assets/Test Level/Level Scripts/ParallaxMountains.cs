using UnityEngine;
using System.Collections;

public class ParallaxMountains : MonoBehaviour {

	public float scrollSpeed = 0.0035f;
	public Renderer rend;
	void Start() 
	{
		rend = GetComponent<Renderer>();
	}
	void Update() 
	{
		float offset = Time.time * scrollSpeed;
		rend.material.mainTextureOffset = new Vector2(offset, 0);
	}
}
