using UnityEngine;
using System.Collections;

public class EnemyJump : MonoBehaviour {

	public GameObject wolfParent;
	public float jumpPower = 0.1f;
	public int maxFrameTime = 30;

	IEnumerator WolfJump()
	{
		int timeInFrames = maxFrameTime;
		while (timeInFrames > 0) {
			wolfParent.transform.Translate (0, jumpPower, 0);
			timeInFrames--;
			yield return new WaitForEndOfFrame ();
		}
		timeInFrames = maxFrameTime;
	}

	void OnTriggerEnter()
	{
		StartCoroutine (WolfJump ());
		print ("wolf is jumping");
	}

}
