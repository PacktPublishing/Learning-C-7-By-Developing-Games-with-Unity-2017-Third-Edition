using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {
	
	bool isCollected = false;

	void Show() {
		this.GetComponent<SpriteRenderer>().enabled = true;
		this.GetComponent<CircleCollider2D>().enabled = true;
		isCollected = false;
	}

	void Hide() {
		this.GetComponent<SpriteRenderer>().enabled = false;
		this.GetComponent<CircleCollider2D>().enabled = false;
	}


	void Collect() {

		isCollected = true;
		Hide();
		GameManager.instance.CollectedCoin();
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		if (other.tag == "Player") {
			Collect();
		}
	}	
}
