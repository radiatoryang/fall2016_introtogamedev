using UnityEngine;
using UnityEngine.SceneManagement; // we need this line in order to change the scene in-game
using System.Collections;

public class RestartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log( "scene started!" );
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.R) ) {
			// each scene has a "build index" ID number
			// the "build index" number is visible in File > Build Settings menu
			SceneManager.LoadScene( 0 );
		}

	}
}
