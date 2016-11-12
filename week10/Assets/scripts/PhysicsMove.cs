using UnityEngine;
using System.Collections;

// does not use transform.Translate, instead hooks into Physics forces
public class PhysicsMove : MonoBehaviour {

	public float moveSpeed = 10f; // tuning variable for movement speed

	// STEP 1: create a shortcut for physics
	public Rigidbody2D myRigidbody; // assign this reference in Inspector
	
	// Update is called once per frame
	void Update () {
		// STEP 2: apply physics forces
		if ( Input.GetKey(KeyCode.UpArrow) ) {
			myRigidbody.AddForce( new Vector2 (0f, moveSpeed) );
		}

		if ( Input.GetKey(KeyCode.DownArrow) ) { // MOVE DOWN
			myRigidbody.AddForce( new Vector2 (0f, -moveSpeed) );
		}

		if ( Input.GetKey(KeyCode.LeftArrow) ) { // MOVE LEFT
			myRigidbody.AddForce( new Vector2 (-moveSpeed, 0f) );
		}

		if ( Input.GetKey(KeyCode.RightArrow) ) { // MOVE RIGHT
			myRigidbody.AddForce( new Vector2 (moveSpeed, 0f) );
		}

	}
}
