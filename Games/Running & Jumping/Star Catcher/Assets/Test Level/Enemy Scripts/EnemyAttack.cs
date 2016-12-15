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

	public AudioClip tumbleHit;
	public AudioClip wolfHit;
	public AudioSource source;

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
		//print ("Rabbit can be damaged");
	}

	void OnTriggerEnter(){
		if (canBeDamaged) {

			playerAnim.Play ("RabbitDamage");
			if (StaticPointSystem.starCount >= 0) {
				StaticPointSystem.starCount -= damage;
				textEffect.StarBoost ("-" + damage, Color.red);
				if (StaticPointSystem.starCount < 0) {
					StaticPointSystem.starCount = 0;
				}
			}
			switch (damage) {
			case 1:
				source.clip = tumbleHit;
				break;
			case 5:
				source.clip = wolfHit;
				break;
			default:
				break;
			}
			source.Play ();
			StartCoroutine (DamagePlayer ());
				
		}
	}

}
