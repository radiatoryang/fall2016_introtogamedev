using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {

	void Start () {
		// destroy myself after 10 seconds, to make sure I don't live forever if I don't hit anything
		Destroy( this.gameObject, 10f );
	}

	// Update is called once per frame
	void Update () {
		// make the projectile always move to the right
		// both of these lines of code do the same thing
		// ONLY CHOOSE ONE OF THESE
		transform.Translate( 5f * Time.deltaTime, 0f, 0f );
		// transform.position += new Vector3(5f * Time.deltaTime, 0f, 0f );
	}

	void OnTriggerEnter2D( Collider2D activator ) {
		// if this activator is tagged BulletPass, then ignore it
		if ( activator.tag == "BulletPass" ) {
			return; // ... then end this function early and ignore it
		}

		// when my trigger touches something, then:
		// 1. does this thing have a Damageable script on it?
		if ( activator.GetComponent<Damageable>() != null ) {
			// if so, then decrease health by 1
			activator.GetComponent<Damageable>().remainingHealth -= 1;
		}
		// 2. destroy myself
		Destroy( this.gameObject );
	}

}
