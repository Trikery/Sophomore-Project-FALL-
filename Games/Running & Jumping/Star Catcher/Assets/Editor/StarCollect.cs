using UnityEngine;
using System.Collections;

public class StarCollect : MonoBehaviour {

	public GameObject parent;

	void Start (){
		parent = GetComponentInParent<GameObject> ();
	}

	void OnTriggerEnter(){
		StaticPointSystem.starCount++;
		Destroy (parent.gameObject);
		print (StaticPointSystem.starCount);
	}
}
