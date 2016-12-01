﻿using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	public Animator countAnim;
	public MainMenu main;

	public int timerMax = 3;

	void Start (){
		StartCoroutine (CountDownTimer ());
	}

	public IEnumerator CountDownTimer ()
	{
		int timer = timerMax;
		main.controls.enabled = false;
		countAnim.Play ("CountDown");
		while (timer > 0) {
			yield return new WaitForSeconds (1);
			timer--;
		}
		timer = timerMax;
		ActivateGame ();
	}

	void ActivateGame (){
		main.widgets.SetActive (true);
		main.controls.enabled = true;
		main.starSpawners.SetActive (true);
		main.cameraMovement.enabled = true;
		main.skyTimer.enabled = true;
		this.gameObject.SetActive (false);

	}
}