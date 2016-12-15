using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour {
	
	public void ReturnToMenu (){
		StageRecycleVars.nextSectionPosition = 28;
		StageRecycleVars.distance = 14;
		StaticPointSystem.gameTimer = 125;
		StaticPointSystem.starCount = 0;
		StaticPointSystem.timer = StaticPointSystem.maxtimer;
		SceneManager.LoadScene ("TestStage", LoadSceneMode.Single);
	}

	void Start () {
		
	}
}
