using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyApproach : MonoBehaviour {

	public float approachSpeed = 1;

	public Color dangerColor;
	public Vector3 moveIcon;
	public Text timerText;
	public EnemyEntrance enterWolf;
	public EnemyAmbushFlash flashFunction;

	public bool canSpawnWolf = true;
	public int flashTimeLimitMax = 120;

	public void GetStar(){
		StaticPointSystem.timer++;
	}

	IEnumerator PlayAmbushFlash()
	{
		int flashTimeLimit = flashTimeLimitMax;
		flashFunction.StartFlash ();
		flashFunction.FlashAnimation ();
		while (flashTimeLimit > 0) 
		{
			flashTimeLimit--;
			yield return new WaitForEndOfFrame();
		}
		enterWolf.EnemyActivator ();
		flashTimeLimit = flashTimeLimitMax;
		flashFunction.EndFlash();


	}


	void Update ()
	{
		if (StaticPointSystem.timer > 0) {
			timerText.text = "" + StaticPointSystem.timer.ToString ("F0");
			StaticPointSystem.timer -= 1 * Time.deltaTime;
			if (StaticPointSystem.timer < 5) {
				timerText.color = dangerColor;
			}else{
				timerText.color = new Color (1, 1, 1, 1);
			}


			//moveIcon.x = approachSpeed * Time.deltaTime;
			//transform.Translate (moveIcon);
		} else {
			if (canSpawnWolf) {
				StartCoroutine (PlayAmbushFlash ());
				canSpawnWolf = false;
			}

		}

	}
}
