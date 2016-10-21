using UnityEngine;
using System.Collections;

public class ParallaxBG : MonoBehaviour {

	public float scrollSpeed = 0.02f;
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
