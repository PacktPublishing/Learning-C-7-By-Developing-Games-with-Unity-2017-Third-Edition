using UnityEngine;
using System.Collections;

public class LearningObjectsWithConstructors : MonoBehaviour {


	public Person man;
	public Person woman;



	void Start() {

		man = new Person("Greg", "Lukosek");
		woman = new Person("Kate", "Lukosek");

		man.spouse = woman;
		woman.spouse = man;

		if (man.IsMarriedWith(woman)) {
			Debug.Log(man.firstName + " is married to " + woman.firstName);
		}
		else {
			Debug.Log(man.firstName + " and " + woman.firstName + " are not married");
		}
	}
}




