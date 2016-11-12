using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	// this function automatically happens when this script's trigger gets triggered
	// at least this trigger, or activator, MUST have a Rigidbody2D on it though
	void OnTriggerEnter2D( Collider2D activator ) {
		// DESTROY THE PLAYER
		Destroy( activator.gameObject );
	}

}
