using UnityEngine;
using System.Collections;

public class TumbleweedSpawner : MonoBehaviour {

	public int timeMin = 5;
	public int timeMax = 8;

	public bool canSpawnTumbleweed = true;

	public Transform tumbleweed;
	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		StartCoroutine(WaitForTumble ());
	}


	IEnumerator WaitForTumble()
	{
		while (canSpawnTumbleweed){
			int randomTime = Random.Range(5, 8); 
			yield return new WaitForSeconds (randomTime);
			Instantiate (tumbleweed, spawnPoint.position, Quaternion.identity);
			StartCoroutine(WaitForTumble ());
		}
	}

}
