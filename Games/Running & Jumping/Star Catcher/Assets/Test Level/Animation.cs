using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

	public enum AnimatedCycle {Run,Idle,Jump};

	public AnimatedCycle currentAnim; 
	public Animator Animator; 

	void TransitionTo(AnimatedCycle anim, string name)
	{
		// Check if the animation is already playing or not/
		if (currentAnim != anim) {
			Animator.Play (name);
			currentAnim = anim;
		}
	}
//	void Update () 
//	{
//		switch (AnimatedCycle){
//		case AnimatedCycle.Idle:
//			TransitionTo(AnimatedCycle.Idle, "NameOfIdleAnimation");
//			break;
//		case AnimatedCycle.Run:
//			TransitionTo (AnimatedCycle.Run, "NameOfWalkingAnimation");
//			break;
//		case AnimatedCycle.Jump:
//			TransitionTo (AnimatedCycle.Jump, "NameOfIdleAnimation");
//			break;
//		}
//	}
}
