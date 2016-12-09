using UnityEngine;
using System.Collections;

public class GameStates {
	
	public enum States {OpenMenu, CloseMenu, StartGame};
	public static States currentState = States.OpenMenu;


}
