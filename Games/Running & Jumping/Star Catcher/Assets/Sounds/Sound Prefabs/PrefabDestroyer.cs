using UnityEngine;
using System.Collections;

public class PrefabDestroyer : MonoBehaviour {

	public float destroyTime = 0;

	void Start(){
		Destroy (this.gameObject, destroyTime); 
	}

}
