using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour{

	public GameObject thisPowerUp;
	public PowerUpList list;

	public float rotateSpeed = 10f;

	void OnEnable(){
		StartCoroutine (Spin ());
		list = GetComponentInParent<PowerUpList> ();
	}

	protected virtual void PowerEffect (){
		print ("Whats The Power?");
	}

	protected IEnumerator Spin(){
		transform.Rotate (rotateSpeed, -rotateSpeed, rotateSpeed);
		yield return null;
		StartCoroutine (Spin ());
	}

	protected virtual void OnTriggerEnter(){
		thisPowerUp.SetActive (false);
		list.CollectedPowerUps.Add (this.gameObject);
		PowerEffect ();
		//print (StaticVariables.totalCoins);
	}

}
