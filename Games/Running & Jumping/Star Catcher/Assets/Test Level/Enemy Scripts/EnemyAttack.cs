using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	
	public bool canBeDamaged = true;
	public int maxInvins = 5;

	public GameObject player;
	public Animator playerAnim;
	public SpriteRenderer sprite;

	IEnumerator flashRed(){
		sprite.color = new Color (.5f, 0, 0, .5f);
		yield return new WaitForSeconds (.25f);
		sprite.color = new Color (1, 1, 1, 1);
	}

	IEnumerator flashGreen(){
		sprite.color = new Color (.7f, 0, 0, .5f);
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
			yield return new WaitForSeconds (.5f);
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
				if (StaticPointSystem.starCount < 0) {
					StaticPointSystem.starCount = 0;
				}
			}

			StartCoroutine (DamagePlayer ());
				
		}
	}

}
