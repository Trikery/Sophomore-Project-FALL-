using UnityEngine;
using System.Collections;

public class CharacterFalls : MonoBehaviour {

	public MainMenu main;
	public GameObject character;
	public Canvas gameOver;
	public Canvas widgets;
	public Animator anim;
	public CharacterMovement move;

	IEnumerator DeathTimerMain (int time){
		int timeLimit = time;
		while (timeLimit > 0) {
			timeLimit--;
			character.transform.Translate (-0.06f, 0, 0);  //this is so the player can see the rabbit dying as the smoke eats it
			yield return new WaitForEndOfFrame ();
		}
		character.SetActive (false);
		timeLimit = time;
		main.cameraMovement.enabled = false;
		widgets.enabled = false;
		gameOver.enabled = true;
		GameStates.currentGameState = GameStates.States.RestartScreen;
	} 

	public void DeathActivator () {

		move.Unsubscribe ();
		anim.Play ("RabbitDamage");
		StartCoroutine (DeathTimerMain(20));

	}


	void OnTriggerEnter (){  //when the player enters the death area, the scene will reset
		DeathActivator();


	}  //MonoDevelop says this is obsolete.  I guess that means there is a better way to do it now.  But right now I donw't care
}
