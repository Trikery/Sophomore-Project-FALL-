using UnityEngine;
using System.Collections;

public class TumbleweedDestroy : MonoBehaviour {

	public float destroyTime = 15f;

	void Start () {
		Destroy (this.gameObject, destroyTime);
		print ("destroyed Tumbleweed");
	}
}
