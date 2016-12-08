using UnityEngine;
using System.Collections;

public class LoopingSoundDemo : MonoBehaviour {

	AudioSource myAudioSource;

	void Start () {
		myAudioSource = GetComponent<AudioSource>();
	}

	void Update () {
		if ( Input.GetKeyDown(KeyCode.L) ) {
			myAudioSource.loop = !myAudioSource.loop; // sets the bool equal to its opposite value
			// if the sound is playing, then stop it
			if ( myAudioSource.isPlaying ) {
				myAudioSource.Stop();
			} else { // if the sound is stopped, then play it
				myAudioSource.Play();
			}

			// myAudioSource.Pause(); // pauses a sound
			// myAudioSource.Unpause(); // unpauses a sound
		}
	}
}
