using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

	public StartButton Restart;

	public void RestartThisGame (){
		StageRecycleVars.nextSectionPosition = 14;
		StageRecycleVars.distance = 14;
		StaticPointSystem.starCount = 0;
		StaticPointSystem.timer = 20;
		SceneManager.LoadScene ("TestStage", LoadSceneMode.Single);
		Restart.ActivateCount ();
	}
		
	void Start () {
	
	}
}
