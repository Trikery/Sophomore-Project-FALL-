using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	public Animator countAnim;
	public MainMenu main;
	public AudioSource openJingle;
	public AudioSource music;

	public int timerMax = 3;

	void Start (){
		StartCoroutine (CountDownTimer ());
	}

	public IEnumerator CountDownTimer ()
	{
		int timer = timerMax;
		main.controls.enabled = false;
		countAnim.Play ("CountDown");
		openJingle.Play (0);
		while (timer > 0) {
			yield return new WaitForSeconds (1);
			timer--;
		}
		timer = timerMax;
		music.Play (0);
		ActivateGame ();

	}

	void ActivateGame (){
		main.widgets.SetActive (true);
		main.controls.enabled = true;
		main.starSpawners.SetActive (true);
		main.cameraMovement.enabled = true;
		main.skyTimer.enabled = true;
		main.tumbleweedSpawnerObject.SetActive (true);
		this.gameObject.SetActive (false);

	}
}
