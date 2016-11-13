using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour {

	public EnemyEntrance destroyActivator;
	public EnemyApproach respawnEnemy;

	void ResetTimer()
	{
		StaticPointSystem.timer = 60;
	}

	void OnTriggerEnter()
	{
		respawnEnemy.canSpawnWolf = true;
		ResetTimer ();
		destroyActivator.EnemyDestroy ();
	}

}
