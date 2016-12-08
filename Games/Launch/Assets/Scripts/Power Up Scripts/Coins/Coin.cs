using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public GameObject thisCoin;
	public CoinsList list;

	public float rotateSpeed = 10f;

	void OnEnable(){
		StartCoroutine (Spin ());
		list = GetComponentInParent<CoinsList> ();
	}

	protected IEnumerator Spin(){
		transform.Rotate (0, 0, rotateSpeed);
		yield return null;
		StartCoroutine (Spin ());
	}

	protected virtual int getValue (){
		return 0;
	}

	protected virtual void OnTriggerEnter(){
		list.CollectedCoins.Add (this.gameObject);
		thisCoin.SetActive (false);
		StaticVariables.totalCoins += getValue ();
		//print (StaticVariables.totalCoins);
	} 
}
