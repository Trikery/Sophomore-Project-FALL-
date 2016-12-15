using UnityEngine;
using System.Collections;

public class GameOverMusic : MonoBehaviour {

	public AudioSource source;
	public ulong delayTime;

	void OnEnable () {
		source.Play(delayTime);
	}

}
