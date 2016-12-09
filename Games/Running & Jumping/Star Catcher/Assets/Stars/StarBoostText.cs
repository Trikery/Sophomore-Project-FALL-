using UnityEngine;
using System.Collections;

public class StarBoostText : MonoBehaviour {

	public GameObject starBoost;
	public TextMesh starBoostAnim;
	public Transform starLocal;

	public void StarBoost (string _s, Color _c){
		starBoostAnim.GetComponent<TextMesh> ().text = _s;
		starBoostAnim.GetComponent<TextMesh> ().color = _c;

		Instantiate (starBoost, starLocal.transform.position, Quaternion.identity);

	}

}
