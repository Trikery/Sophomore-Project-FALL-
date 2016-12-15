using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CharacterFalls : MonoBehaviour {

	public MainMenu main;
	public GameObject character;
	public GameObject gameOver;
	public GameObject widgets;
	public Animator anim;
	public CharacterMovement move;

	public AudioSource levelAudio;
	public AudioSource deathJingle;
	public float fadeRate = 0.01f;

//	public EventSystem buttonSystem;
//	public GameObject restartButton;

	public IEnumerator FadeOutSound (AudioSource source){
		while (source.volume > 0) {
			source.volume -= fadeRate;
			yield return new WaitForEndOfFrame ();
		}
		source.Stop ();
	}


	public void RestartScreen () {
		StartCoroutine (FadeOutSound (levelAudio));
		character.SetActive (false);
		main.cameraMovement.enabled = false;
		main.starSpawners.SetActive (false);
		main.tumbleweedSpawnerObject.SetActive (false);
		main.skyTimer.enabled = false;
		widgets.SetActive (false);
		gameOver.SetActive (true);
		GameStates.currentGameState = GameStates.States.RestartScreen;
//		buttonSystem.firstSelectedGameObject = restartButton;
	}

	IEnumerator DeathTimerMain (int time){
		int timeLimit = time;
		while (timeLimit > 0) {
			timeLimit--;
			character.transform.Translate (-0.05f, 0, 0);  //this is so the player can see the rabbit dying as the smoke eats it
			yield return new WaitForEndOfFrame ();
		}
		timeLimit = time;
		RestartScreen ();
	} 

	public void DeathActivator () {

		move.Unsubscribe ();
		anim.Play ("RabbitDamage");
		deathJingle.Play ();
		StartCoroutine (FadeOutSound (levelAudio));
		StartCoroutine (DeathTimerMain(20));
	}


	void OnTriggerEnter (){  //when the player enters the death area, the scene will reset
		DeathActivator();


	}  //MonoDevelop says this is obsolete.  I guess that means there is a better way to do it now.  But right now I donw't care
}
