using UnityEngine;
using System.Collections;

public class LearningLoopsWhile : MonoBehaviour {


	public bool condition = false;


	void Start() {


//		while (condition) {
//
//			//loop block
//
//		}


		int i = 0;

		while (i<10) {
			
			//loop block
			Debug.Log(i);
			i++;
		}




	}



}
