using UnityEngine;
using System.Collections;

public class PlayerAxisControl : MonoBehaviour {

	public float speed = 5f;
	
	void Update () {
		// "horizontal" input, Keyboard A/D or LeftArrow/RightArrow
		// GetAxis returns -1 to 1... it is 0 if nothing is pressed
		float horizontal = Input.GetAxis("Horizontal");
		// up/down, w/s
		float vertical = Input.GetAxis("Vertical");

		// Time.deltaTime = the length of the frame in seconds
		// multiply stuff by dT to make a behaviour framerate INDEPENDENT
		transform.Translate( horizontal * Time.deltaTime * speed, vertical * Time.deltaTime * speed, 0f );
		// for example, 100 FPS... dT = 0.01f... what about 10 FPS? dT = 0.1f
	}

}
