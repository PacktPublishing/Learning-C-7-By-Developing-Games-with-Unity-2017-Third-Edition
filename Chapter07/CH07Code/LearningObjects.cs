using UnityEngine;
using System.Collections;

public class LearningObjects : MonoBehaviour {


	public Person man;
	public Person woman;



	void Start() {


		man = new Person();
		man.firstName = "Greg";
		man.lastName = "Lukosek";

		woman = new Person();
		woman.firstName = "Kate";
		woman.lastName = "Lukosek";

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




