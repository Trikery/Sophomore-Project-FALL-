using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour {

	public List<GameObject> titles;
	public Text loadingText;

	//Because my GameState Controller isn't working I will need to use these for now.
	public GameObject player;
	public GameObject title;

	IEnumerator ShowTitle(){
		for (int i = 0; i < titles.Count; i++) {
			yield return new WaitForSeconds (.5f);
			titles [i].SetActive (true);
		}
		StartCoroutine (gameStartTimer ());
	}

	IEnumerator gameStartTimer(){
		int maxTimer = 3;
		int timer = maxTimer;
		loadingText.enabled = true;
		while (timer > 0) {
			loadingText.text = "Loading..." + timer;
			timer--;
			yield return new WaitForSeconds (1);
		}
		loadingText.enabled = false;
		timer = maxTimer;
		player.SetActive (true);
		title.SetActive (false);

	}

	void Start () {
		GameStateController.ChangeState (GameStates.States.OpenMenu);
		loadingText.enabled = false;
		player.SetActive (false);

		for (int i = 0; i < titles.Count; i++) {
			titles [i].SetActive (false);
		}
		StartCoroutine (ShowTitle ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
