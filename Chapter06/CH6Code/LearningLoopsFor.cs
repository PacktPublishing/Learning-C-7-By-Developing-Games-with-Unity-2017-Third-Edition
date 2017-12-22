using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LearningLoopsFor : MonoBehaviour {


	public List<string> familyMembers = new List<string>();
	
	
	void Start() {
		
		familyMembers.Add("Greg");
		familyMembers.Add("Kate");
		familyMembers.Add("Adam");
		familyMembers.Add("Mia");


		for( int i = 0; i < familyMembers.Count; i++) {
			
			//loop block
			Debug.Log(familyMembers[i]);
		}


	}


}
