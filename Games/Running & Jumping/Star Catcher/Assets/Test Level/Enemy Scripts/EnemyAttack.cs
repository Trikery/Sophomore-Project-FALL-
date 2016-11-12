using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	
	public bool canBeDamaged = true;
	public int maxInvins = 5;

	public GameObject player;
	public Animator playerAnim;
	public SpriteRenderer sprite;

	IEnumerator flashRed(){
		sprite.color = Color.red;
		yield return new WaitForSeconds (1);
		sprite.color = Color.white;
	}

	IEnumerator flashGreen(){
		sprite.color = Color.green;
		yield return new WaitForSeconds (0.25f);
		sprite.color = Color.white;
	}

	IEnumerator DamagePlayer()
	{
		int invinsibilityTime = maxInvins;
		canBeDamaged = false;
		while (invinsibilityTime > 0) {
			if (invinsibilityTime > 1) {
				StartCoroutine (flashGreen ());
			} else {
				StartCoroutine (flashRed ());
			}
			invinsibilityTime--;
			print (invinsibilityTime);
			yield return new WaitForSeconds (1);
		}
		canBeDamaged = true;
		invinsibilityTime = maxInvins;
		print ("Rabbit can be damaged");
	}

	void OnTriggerEnter(){
		if (canBeDamaged) {
			if (StaticPointSystem.starCount <= 0) {
				print ("you're Dead!");
			}

			print("Rabbit Damage");
			playerAnim.Play ("RabbitDamage");
			if (StaticPointSystem.starCount >= 0) {
				StaticPointSystem.starCount -= 5;
			}
			StartCoroutine (DamagePlayer ());
				
		}
	}

}
