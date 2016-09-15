using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	public GameObject character;
	public CharacterMovement accessSpeed;
	void OnTriggerEnter (){
		gameObject.SetActive (false);
		accessSpeed.moveSpeed = accessSpeed.moveSpeed + 10;

	}
}
