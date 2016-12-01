using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public GameObject thisCoin;
	public float rotateSpeed = 10f;


	void Start (){
		StartCoroutine (Spin ());
	}

	IEnumerator Spin(){
		transform.Rotate (0, 0, rotateSpeed);
		yield return null;
		StartCoroutine (Spin ());
	}

	protected virtual int getValue (){
		return 0;
	}

	void OnTriggerEnter(){
		thisCoin.SetActive (false);
		StaticVariables.totalCoins += getValue ();
		print (StaticVariables.totalCoins);
	} 
}
