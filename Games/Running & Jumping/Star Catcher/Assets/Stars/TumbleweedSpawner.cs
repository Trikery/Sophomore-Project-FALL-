using UnityEngine;
using System.Collections;

public class TumbleweedSpawner : MonoBehaviour {

	public int timeMin = 5;
	public int timeMax = 8;

	public bool canSpawnTumbleweed = true;

	public Transform tumbleweed;
	public Transform spawnPoint;

	public AudioSource audio;

	// Use this for initialization
	void Start () {
		StartCoroutine(WaitForTumble ());
	}


	IEnumerator WaitForTumble()
	{
		int randomTime = Random.Range(timeMin, timeMax); 
		audio.Play ();
		Instantiate (tumbleweed, spawnPoint.position, Quaternion.identity);
		while (randomTime > 0) {
			randomTime--;
			yield return new WaitForSeconds (1);
		}
		StartCoroutine(WaitForTumble ());
	}

}
