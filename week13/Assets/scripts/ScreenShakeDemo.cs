using UnityEngine;
using System.Collections;

// put this on your camera
public class ScreenShakeDemo : MonoBehaviour {

	Vector3 startPosition;
	float shakeStrength = 0f;

	void Start () {
		// remember where the camera started
		startPosition = transform.position;
	}

	void Update () {
		// DEBUG TEST: hold spacebar to shake the screen
		if ( Input.GetKey(KeyCode.Space) ) {
			shakeStrength = 1f;
		}
		// decay shakeStrength over time
		shakeStrength = Mathf.Clamp( shakeStrength - Time.deltaTime, 0f, 1f);

		// multiply INSIDE sine wave = faster frequency, speed, duration of period
		// multiply OUTSIDE sine wave = distance, amplitude
		transform.position = startPosition + shakeStrength * (
							  		transform.right * Mathf.Sin( Time.time * 17f ) * 0.16f
									+ transform.up * Mathf.Sin( Time.time * 19f ) * 0.16f
							 );


	}
}
