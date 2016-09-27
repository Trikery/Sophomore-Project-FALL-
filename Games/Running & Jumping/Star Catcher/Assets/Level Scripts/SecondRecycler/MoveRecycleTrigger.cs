using UnityEngine;
using System.Collections;
using Cubes;

namespace Cubes 
{
	public class MoveRecycleTrigger : MonoBehaviour 
	{

		private Vector3 movePos;
		public float speed = 1;

		void Update ()
		{
			movePos.x = speed * Time.deltaTime;
			transform.Translate (movePos);
			
		}




	}
}
