using UnityEngine;
using System.Collections;

public class Damageable : MonoBehaviour {

	// "public" means other scripts (like ProjectileScript.cs) can access this variable
	public int remainingHealth = 10;

	void Update () {
		// very simple script: if my health is less than or equal to 0...
		if ( remainingHealth <= 0 ) {
			// ... then destroy myself
			Destroy( this.gameObject );
		}
	}
}
