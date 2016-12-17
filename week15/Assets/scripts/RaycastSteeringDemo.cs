using UnityEngine;
using System.Collections;

// put this script on your Roomba gameObject
public class RaycastSteeringDemo : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// how to raycast!
		// https://docs.unity3d.com/ScriptReference/Physics2D.Raycast.html

		// setup our variables
		Vector2 origin = transform.position; // where the raycast starts
		Vector2 direction = transform.up; // get this object's local Y axis, "in front" of us
		float distance = 0.75f; // how long the raycast is

		// when we actually shoot the raycast now, and see if anything is in front of us
		RaycastHit2D raycastResults = Physics2D.Raycast( origin, direction, distance );

		// visualize the raycast: draws a debug line in the Scene view
		Debug.DrawRay( origin, direction * 0.75f, Color.cyan );

		// let's see if the raycast hit anything? if so, randomly turn left or right
		if ( raycastResults.collider != null ) {
			if ( Random.Range(0f, 1f) > 0.5f ) { // flip a coin... 50% chance to turn left
				transform.Rotate(0f, 0f, 90f);
			} else {
				transform.Rotate(0f, 0f, -90f);
			}
		} else { // if the raycast didn't hit anything, then move forward
			transform.position += transform.up * Time.deltaTime * 5f; // move "forward" (Y axis, up)
		}

	}

}
