using UnityEngine;
using System.Collections;

public class EnemyEntrance : MonoBehaviour {
	public GameObject enemy;
	public MoveCamera cameraSpeedChange;
	public GameObject enemyStartPosition;
	public EnemyMovement moveableEnemy;

	public void EnemyActivator(){
		enemy.SetActive (true);
		print ("enemy is alive");
		enemy.transform.position = enemyStartPosition.transform.position;
		cameraSpeedChange.speed = 6f;
		StartCoroutine (moveableEnemy.WolfMover ());
	}	

	public void EnemyDestroy(){
		print ("Enemy was killed");
		cameraSpeedChange.speed = 5f;
		enemy.SetActive (false);
		
	}
}
