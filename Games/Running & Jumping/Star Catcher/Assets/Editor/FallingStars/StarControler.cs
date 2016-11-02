using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class StarControler : MonoBehaviour {

	public List<Transform> spawners;
	public List<Transform> stars;
 
	void SpawnHandler (Transform _t)
	{
		spawners.Add (_t);
	}

	void StarHandler (Transform _t)
	{
		stars.Add (_t);
	}

	void Start () {
		StarSpawner.SendSpawner += SpawnHandler;
		Stars.SendStar += StarHandler;
		StartCoroutine (Spawn ());
	}

	private bool canSpawn = true;

	private int starNum;
	private int spawnerNum;

	IEnumerator Spawn()
	{
		while (canSpawn) {
			yield return new WaitForSeconds (1);
			stars [starNum].position = spawners [0].position;
			stars [starNum].GetComponent<MeshRenderer> ().enabled = true;
			if (starNum < stars.Count - 1) {
				starNum++;
			} else {
				starNum = 0;
			}
			if (spawnerNum < spawners.Count - 1) {
				spawnerNum++;
			} else {
				spawnerNum = 0;
			}
		

		}


	}
}
