using UnityEngine;
using System.Collections;

public class GameOverMusic : MonoBehaviour {

	public AudioClip gameOver;
	public AudioClip winnerClip;

	public AudioSource source;
	public ulong delayTime;

	void OnEnable () {
		if (StaticPointSystem.gameTimer == 0) {
			source.clip = winnerClip;
			source.Play (delayTime);
		} else {
			source.clip = gameOver;
			source.Play ();
		}
	}

}
