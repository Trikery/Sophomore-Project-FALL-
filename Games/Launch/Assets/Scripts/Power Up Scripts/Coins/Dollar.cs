using UnityEngine;
using System.Collections;

public class Dollar : Coin {

	public GameObject player;
	public PowerUpList plist;

	protected override int getValue (){
		return 100;
	}

	protected override void OnTriggerEnter(){
		
		list.CollectedCoins.Add (this.gameObject);
		thisCoin.SetActive (false);
		StaticVariables.totalCoins += getValue ();

		foreach (GameObject coin in list.CollectedCoins) {
			coin.SetActive (true);
		}

		foreach (GameObject pUp in plist.CollectedPowerUps) {
			pUp.SetActive (true);
		}

		plist.CollectedPowerUps.Clear ();
		list.CollectedCoins.Clear ();
		player.transform.position = new Vector3 (0, 0.5f, 0);

	}
}


