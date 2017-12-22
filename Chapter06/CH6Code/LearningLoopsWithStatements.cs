using UnityEngine;
using System.Collections;

public class LearningLoopsWithStatements : MonoBehaviour {


	void Start () {
	
		for( int i = 0; i < 1000; i++) {

			if (i == 0) {
				Debug.Log(i + " is zero");
			}
			else if (IsNumberEven(i)) {
				Debug.Log(i + " is even");
			}
			else {
				Debug.Log(i + " is odd");
			}
		}
	}
	

	public bool IsNumberEven(int number) {

		if (number % 2 == 0) {
			return true;
		}
		else {
			return false;
		}
	}


}



