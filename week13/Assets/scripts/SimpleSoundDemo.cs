using UnityEngine;
using System.Collections;

public class SimpleSoundDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			// this is INTERRUPTABLE; if the sound is playing, and you play it again, it restarts
			// GetComponent<AudioSource>().Play(); // Play the sound

			// this version is NOT INTERRUPTABLE:
			if ( GetComponent<AudioSource>().isPlaying == false ) {
				GetComponent<AudioSource>().Play();
			}
		}
	}
}
