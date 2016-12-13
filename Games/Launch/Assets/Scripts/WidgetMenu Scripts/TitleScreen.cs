using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour {

	public List<GameObject> titles;								//List #3
	public Text loadingText;

	//Because my GameState Controller isn't working I will need to use these for now.
	public GameObject player;
	public GameObject title;

	IEnumerator ShowTitle(){									//Coroutine #1
		for (int i = 0; i < titles.Count; i++) {				//For Loop #1
			yield return new WaitForSeconds (.5f);
			titles [i].SetActive (true);
		}
		StartCoroutine (gameStartTimer ());
	}

	IEnumerator gameStartTimer(){								//Coroutine #2
		int maxTimer = 3;
		int timer = maxTimer;
		loadingText.enabled = true;
		while (timer > 0) {										//While Loop #1
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

		for (int i = 0; i < titles.Count; i++) {				//For Loop #2
			titles [i].SetActive (false);
		}
		StartCoroutine (ShowTitle ());
	}
}
