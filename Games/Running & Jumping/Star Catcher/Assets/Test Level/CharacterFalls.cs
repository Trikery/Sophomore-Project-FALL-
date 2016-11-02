using UnityEngine;
using System.Collections;

public class CharacterFalls : MonoBehaviour {

	public MainMenu main;
	public GameObject character;
	public Canvas gameOver;
	public Canvas widgets;

	public void DeathActivator () {
		character.SetActive (false);
		main.cameraMovement.enabled = false;
		widgets.enabled = false;
		gameOver.enabled = true;
		GameStates.currentGameState = GameStates.States.RestartScreen;
	}


	void OnTriggerEnter (){  //when the player enters the death area, the scene will reset
		DeathActivator();


	}  //MonoDevelop says this is obsolete.  I guess that means there is a better way to do it now.  But right now I donw't care
}
