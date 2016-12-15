using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

	public StartButton Restart;

	public void RestartThisGame (){
		StageRecycleVars.nextSectionPosition = 28;
		StageRecycleVars.distance = 14;
		StaticPointSystem.starCount = 0;
		StaticPointSystem.timer = StaticPointSystem.maxtimer;
		StaticPointSystem.gameTimer = 125;
		StaticPointSystem.canRestartGame = true;
		SceneManager.LoadScene ("TestStage", LoadSceneMode.Single);
		print ("restartingStage");
	}
}
