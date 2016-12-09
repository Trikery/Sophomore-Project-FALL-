using UnityEngine;
using System.Collections;

public class StarBoostSound : MonoBehaviour {

	public TextMesh col;

	public AudioSource source;
	public AudioClip collect;

	void Start () {
		source = GetComponent<AudioSource> ();

		if (col.color == Color.white) {
					source.PlayOneShot (collect);
					print ("print white");
				}
		if (col.color == Color.red) {
				}
		
	}

}
