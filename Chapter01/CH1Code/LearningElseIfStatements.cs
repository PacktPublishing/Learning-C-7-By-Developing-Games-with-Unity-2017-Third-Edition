using UnityEngine;
using System.Collections;

public class LearningElseIfStatements : MonoBehaviour {


	void Start () {
	
		int speedLimit = 60;

		if (speedLimit == 70) {
			Debug.Log("I can drive at maximum speed");
		}
		else if (speedLimit < 70 && speedLimit >= 30) {
			Debug.Log("Speed limit is less than 70 and more or equals to 30");
		}
		else if (speedLimit < 30) {
			Debug.Log("I better be driving slowly, 30 mph or less");
		}
	}


}
