using UnityEngine;
using System.Collections;

public class PhysicsWalk : MonoBehaviour {

	Rigidbody2D myRigidbody;
	Vector2 inputVector; // will remember the direction I want to move

	// Use this for initialization
	void Start () {
		// assign reference automatically IF this script is on same object as Rigidbody2D
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		inputVector = new Vector2(0f, 0f); // first, always reset the input vector

		if ( Input.GetKey(KeyCode.W) ) { // up
			inputVector += new Vector2( 0f, 1f );
		}
		if ( Input.GetKey(KeyCode.A) ) { // left
			inputVector += new Vector2( -1f, 0f );
		}
		if ( Input.GetKey(KeyCode.S) ) { // down
			inputVector += new Vector2( 0f, -1f );
		}
		if ( Input.GetKey(KeyCode.D) ) { // right
			inputVector += new Vector2( 1f, 0f );
		}

		// to (manually) normalize a vector, divide it by its length (or "magnitude")
		// to find out length, use Pythagorean Theorem: c^2 = a^2 + b^2 
//		float cSquared = inputVector.x * inputVector.x + inputVector.y * inputVector.y;
//		float c = Mathf.Sqrt( cSquared ); // find Square Root
//		inputVector = inputVector / c; // divide a Vector by its Length to Normalize It

		// but actually, you would just do this, and have Unity do the Pythagorean Theorem for you:
		inputVector = inputVector.normalized;
	}

	// FixedUpdate is once per PHYSICS FRAME, which is how fast physics runs
	void FixedUpdate () {
		myRigidbody.velocity = inputVector * 5f;
	}
}
