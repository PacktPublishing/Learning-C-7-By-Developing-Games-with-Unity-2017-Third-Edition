using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LearningLoopsForeach : MonoBehaviour {


	public List<string> familyMembers = new List<string>();
	
	
	void Start() {
		
		familyMembers.Add("Greg");
		familyMembers.Add("Kate");
		familyMembers.Add("Adam");
		familyMembers.Add("Mia");
		


		foreach (string familyMember in familyMembers) {

			Debug.Log(familyMember);

		}

	}

}


