using UnityEngine;
using System.Collections;

using UnityEngine.UI; // you need this line to talk to UI Text

public class TappingGame : MonoBehaviour {

	int points = 0; // player's current score

	public Text myTextObject; // "public" exposes it in inspector
	
	// Update is called once per frame
	void Update () {
		// an IF statement is a YES / NO question
		// did the player press SPACEBAR this frame?
		if ( Input.GetKeyDown(KeyCode.Space) == true ) {
			// all 3 of these do exactly the same thing; you choose which one you like
			// points++; // option A
			points += 1; // option B
			// points = points + 1; // option C

			// before we try to get text display working,
			// let's just print the current score to console
			Debug.Log( "test: " + points.ToString() + " points");

			// ok, now that we know it works, let's update the Text object
			myTextObject.text = "YOU HAVE:\n" + points.ToString() + " points!";
		}
	}
}
