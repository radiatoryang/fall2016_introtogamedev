using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	// we want to let players shoot projectiles by instantiating projectiles when they press SPACE
	// STEP 1 to INSTANTIATING: define what we want to INSTANTIATE / "CLONE"
	public GameObject projectilePrefab; // "prefab" = original thing we are cloning
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			// STEP 2: INSTANTIATE THE THING
			Instantiate( projectilePrefab, // thing we want to clone
				transform.position + transform.right, // where the clone should be
				Quaternion.Euler(0f, 0f, 0f) // rotation of the new clone
			);
		}

	}
}
