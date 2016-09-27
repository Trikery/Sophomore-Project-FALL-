using UnityEngine;
using System.Collections;
using System;
using Cubes;

namespace Cubes {

	public class SendToRecycler : MonoBehaviour {

		public static Action <SendToRecycler> SendThis;

		void Start (){
			SendThis (this);
		}
	}
}
