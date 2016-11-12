using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// if player presses W, then move up
		if ( Input.GetKey( KeyCode.W ) ) {
			// Translate moves an object NO MATTER WHAT
			transform.Translate( 0f, 0.5f, 0f );
		}

		// press A to go Left
		if ( Input.GetKey( KeyCode.A ) ) {
			transform.Translate( -0.5f, 0f, 0f );
		}

		// press S to go Down
		if ( Input.GetKey( KeyCode.S ) ) {
			transform.Translate( 0f, -0.5f, 0f );
		}

		// press D to go Right
		if ( Input.GetKey( KeyCode.D ) ) {
			transform.Translate( 0.5f, 0f, 0f );
		}
	}

}
