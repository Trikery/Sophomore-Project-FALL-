using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	
	public bool canBeDamaged = true;
	public int damage = 5;
	public int maxInvins = 5;

	public GameObject player;
	public Animator playerAnim;
	public SpriteRenderer sprite;
	public StarBoostText textEffect;

	IEnumerator flashRed(){
		sprite.color = Color.HSVToRGB (0, .5f, .9f);
		yield return new WaitForSeconds (.25f);
		sprite.color = Color.HSVToRGB (0, 0, 1);
	}

	IEnumerator flashGreen(){
		sprite.color = Color.HSVToRGB (0, .3f, 1);
		yield return new WaitForSeconds (0.25f);
		sprite.color = Color.HSVToRGB (0, 0, 1);
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
				StaticPointSystem.starCount -= damage;
				textEffect.StarBoost ("-" + damage, Color.red);
				if (StaticPointSystem.starCount < 0) {
					StaticPointSystem.starCount = 0;
				}
			}

			StartCoroutine (DamagePlayer ());
				
		}
	}

}
