using UnityEngine;
using System.Collections;

public class KillTrigger : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Player") {
			PlayerController.instance.Kill();
		}
	}







//	void OnTriggerEnter2D(Collider2D other) {
//		
//		if (other.tag == "Player") {
//			//			PlayerController.instance.Kill();
//		}
//	}
}
