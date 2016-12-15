using UnityEngine;
using System.Collections;

public class TumbleweedDestroy : MonoBehaviour {

	public float destroyTime = 15f;
	public AudioClip[] tumbleSound;
	public AudioSource sound;

	void OnCollisionEnter(){
		int audioi = Random.Range (0, tumbleSound.Length);
		sound.PlayOneShot (tumbleSound [audioi]);
	}

	void Start () {
		Destroy (this.gameObject, destroyTime);
		print ("destroyed Tumbleweed");
	}
}
