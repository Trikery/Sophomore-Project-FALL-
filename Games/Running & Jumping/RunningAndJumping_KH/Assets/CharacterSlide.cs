using UnityEngine;
using System.Collections;

public class CharacterSlide : MonoBehaviour {

	public CharacterController character;
	public int slideDuration = 20;
	public float slideTime = 0.01f;

	IEnumerator Slide (){
		int i = 0;
		while (i < slideDuration){

			i++;
			yield return new WaitForSeconds(slideTime);
			print ("sliding");
		}
	}

	void Start (){
		character = GetComponent<CharacterController> ();
		StartCoroutine (Slide ());
	}
}
