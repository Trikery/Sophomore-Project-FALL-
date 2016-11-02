using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyApproach : MonoBehaviour {

	public Vector3 moveIcon;
	public float approachSpeed = 1;
	public Text timerText;
	public CharacterFalls death;

	public void GetStar(){
		StaticPointSystem.timer++;
		moveIcon.x -= 10f;
	}

	void Update ()
	{
		if (StaticPointSystem.timer > 0) {
			timerText.text = "" + StaticPointSystem.timer.ToString ("F0");
			StaticPointSystem.timer -= 1 * Time.deltaTime;
			moveIcon.x = approachSpeed * Time.deltaTime;
			transform.Translate (moveIcon);
		} else {
			death.DeathActivator ();

		}

	}
}
