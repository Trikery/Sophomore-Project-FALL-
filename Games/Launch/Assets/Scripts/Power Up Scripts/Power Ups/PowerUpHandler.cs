using UnityEngine;
using System.Collections;

public class PowerUpHandler : MonoBehaviour {

	public void OnTriggerEnter(Collider other){
		switch (other.gameObject.layer) {
		case 17:
			print ("Got an Empty Pill");
			break;
		case 14:
			print ("Got a RedBlue Pill");
			break;
		}
//		if (other.gameObject.layer == 17){
//			
//		}

//		if (other.gameObject.layer == 14) {
//
//		}
	}
}
