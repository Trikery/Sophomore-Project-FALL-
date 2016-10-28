using UnityEngine;
using System.Collections;

public class EnemyApproach : MonoBehaviour {

	public Vector3 moveIcon;
	public float approachSpeed;
	void Update ()
	{
		moveIcon.x = approachSpeed * Time.deltaTime;
		transform.Translate (moveIcon);
	}
}
