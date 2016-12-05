using UnityEngine;
using System.Collections;

public class EnemyJump : MonoBehaviour {

	public GameObject wolfParent;
	public Animator wolfAnim;

	public float jumpPower = 0.1f;
	public int maxFrameTime = 30;

	bool wolfCanJump = true;

	IEnumerator WolfJump()
	{
		wolfCanJump = false;
		int timeInFrames = maxFrameTime;
		while (timeInFrames > 0) {
			wolfParent.transform.Translate (0, jumpPower, 0);
			wolfAnim.Play ("WolfJumpStart");
			timeInFrames--;
			yield return new WaitForEndOfFrame ();
		}
		timeInFrames = maxFrameTime;
		wolfCanJump = true;
	}

	void OnTriggerStay()
	{
		if (wolfCanJump) {
			StartCoroutine (WolfJump ());
			print ("wolf is jumping");
		}
	}

}
