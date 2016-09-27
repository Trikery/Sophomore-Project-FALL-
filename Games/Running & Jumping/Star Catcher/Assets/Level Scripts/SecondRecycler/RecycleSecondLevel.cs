﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Cubes;

namespace Cubes {

public class RecycleSecondLevel : MonoBehaviour {

		private List<SendToRecycler> recycleList;
		private Vector3 movePos;

		void SendThisHandler (SendToRecycler _r){

			recycleList.Add (_r);
			print (recycleList.Count);
		}

		void Start (){
			recycleList = new List<SendToRecycler> ();
			SendToRecycler.SendThis += SendThisHandler;
		}

		void OnTriggerEnter () 
		{
			movePos.x = Statics.nextPosition;
			recycleList [0].transform.position = movePos;
			Statics.nextPosition += Statics.distance;
		}
}
}