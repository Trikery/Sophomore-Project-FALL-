using UnityEngine;
using System.Collections;

public class CloneStar : MonoBehaviour {

	public Transform[] spawnPoints;
	public Transform star;
	public float spawnFrequency;
	public bool canSpawnStars = true;

	private int i = 0;

	IEnumerator SpawnStars ()
	{
		while (i < spawnPoints.Length - 1)
		{
			i = Random.Range(0, spawnPoints.Length - 1);
			Instantiate (star, spawnPoints [i].position, Quaternion.identity);
			yield return new WaitForSeconds (spawnFrequency);

		}
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnStars ());
	}

}
