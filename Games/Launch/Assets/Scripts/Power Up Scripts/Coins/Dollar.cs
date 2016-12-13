using UnityEngine;
using System.Collections;

public class Dollar : Coin {

	public GameObject player;
	public PowerUpList plist;

	protected override int getValue (){
		return 100;
	}

	IEnumerator winTimer(){												//Coroutine #5
		int maxTimer = 2;
		int timer = maxTimer;
		player.SetActive (false);
		while (timer > 0) {												//While Loop #2
			yield return new WaitForSeconds (1);
			timer--;
		}
		timer = maxTimer;
		LevelReset ();
	}

	void LevelReset(){
		plist.CollectedPowerUps.Clear ();
		list.CollectedCoins.Clear ();
		player.transform.position = new Vector3 (0, 0.5f, 0);
		player.SetActive (true);
	}

	protected override void OnTriggerEnter(){
		
		list.CollectedCoins.Add (this.gameObject);
		StaticVariables.totalCoins += getValue ();

		StartCoroutine (winTimer ());

		foreach (GameObject coin in list.CollectedCoins) {				//ForEach Loop #1
			coin.SetActive (true);
		}

		foreach (GameObject pUp in plist.CollectedPowerUps) {			//ForEach Loop #2
			pUp.SetActive (true);
		}
	}
}


