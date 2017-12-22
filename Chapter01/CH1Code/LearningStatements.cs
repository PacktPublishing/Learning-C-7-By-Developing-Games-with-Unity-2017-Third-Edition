using UnityEngine;
using System.Collections;

public class LearningStatements : MonoBehaviour {
	
	public bool imLateForMeeting = true;
	public bool roadConditionsArePerfect = true;
	
	void Start () {

		if (imLateForMeeting && roadConditionsArePerfect) {
			Debug.Log("I need to drive fast");
		}
	}


	public bool imHugry = false;
	public bool areKidsHungry = true;


	void Other () {
		
		if (imHugry || areKidsHungry) {
			Debug.Log("I should cook some food");
		}
	}





}






