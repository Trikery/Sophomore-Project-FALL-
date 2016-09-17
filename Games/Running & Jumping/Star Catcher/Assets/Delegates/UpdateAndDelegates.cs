using UnityEngine;
using System.Collections;
using System;

public class UpdateAndDelegates : MonoBehaviour {

	//Actions are a type of delegate.  Delegates contain functions just as vars contain data.

	Action DisplayHealth;
	Action KillPlayer;
	Action EndGame;

	int health = 250;

	// Use this for initialization
	void Start () {
		//we assign te function DisplayHealthHandeler to the action DisplayHealth
		DisplayHealth = DisplayHealthHandler;
	}

	void DisplayHealthHandler (){
		print ("Health is Good :)");
		//we unassign all functions inside of DisplayHealth
		DisplayHealth = null;
		KillPlayer = KillPlayerHandler;
	}

	void KillPlayerHandler (){
			print (health);
			health--;
		if (health < 0){
			KillPlayer = null;
			EndGame = EndGameHandler;
		}
		

	}
	void EndGameHandler () {
		print ("you died!");
		EndGame = null;
	}
	// Update is called once per frame
	void Update () {
		//we check to see if any function is inside DisplayHealth.
		//if nothing is assigned, DisplayHealth will not run.
		if (DisplayHealth != null)
			DisplayHealth ();
		
		if (KillPlayer != null)
			KillPlayer ();

		if (EndGame != null)
			EndGame ();
			
	}
}
