using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float jumpForce = 6f;
	public float runningSpeed = 1.5f;
	public Animator animator;

	private Rigidbody2D rigidBody;

	public static bool turnAround;

	void Awake() {
		rigidBody = GetComponent<Rigidbody2D>();
	}

	void Start(){
		turnAround = false;
	}

	public void StartGame() {
		animator.SetBool("isAlive", true);
	}
		

	void FixedUpdate() {

		if (turnAround == true)
		{
			transform.eulerAngles = new Vector3(0,180,0);
		}

		if (turnAround == false)
		{
			transform.eulerAngles = new Vector3(0,0,0);
		}

		if (GameManager.instance.currentGameState == GameState.inGame) 
		{
			if (rigidBody.velocity.x < runningSpeed) {
				rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y);
			}
		}
	}

	void Jump() {
		if (isGrounded()) {
			rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}

	public LayerMask groundLayer;

	bool isGrounded() {

		if (Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundLayer.value)) {
			return true;
		}
		else {
			return false;
		}
	}


	public void Kill() {
		animator.SetBool("isAlive", false);
	}
		
}
