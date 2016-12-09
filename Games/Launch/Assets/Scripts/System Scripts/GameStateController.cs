using UnityEngine;
using System.Collections;

public class GameStateController : MonoBehaviour {

	public static GameObject player;
	public GameObject playerNoStatic;

	public static GameObject coins;
	public GameObject coinsNoStatic;

	public static GameObject powerUps;
	public GameObject powerUpsNoStatic;

	public static GameObject widgets;
	public GameObject widgetsNoStatic;

	public static GameObject title;
	public GameObject titleNoStatic;

	void Start (){
		player = playerNoStatic;
		coins = coinsNoStatic;
		powerUps = powerUpsNoStatic;
		widgets = widgetsNoStatic;
		title = titleNoStatic;
	}

	public static void ChangeState (GameStates.States state){
		GameStates.currentState = state;

		switch (GameStates.currentState) {
		case GameStates.States.OpenMenu:
			print ("Opening Menu");
			player.SetActive (false);
			break;
		case GameStates.States.CloseMenu:
			print ("Closing Menu");
			break;
		case GameStates.States.StartGame:
			print ("Starting Game");
			break;
		} 
	}
}
//Function for Changing States
//GameStateController.ChangeState (GameStates.States.CloseMenu);