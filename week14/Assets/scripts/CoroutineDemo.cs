using UnityEngine;
using System.Collections;

public class CoroutineDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine( MyFirstCoroutine() );
	}

	// coroutines are of "IEnumerator"
	IEnumerator MyFirstCoroutine () {
		Debug.Log("the coroutine started!");
		yield return 0; // "yield return 0" = pause for 1 frame
		Debug.Log("the coroutine continues after waiting 1 frame");
		yield return null; // still 1 frame
		yield return 1; // still 1 frame
		Debug.Log("... ok, the coroutine continues now...");
		yield return new WaitForSeconds( 1f ); // pauses for 1 sec
		Debug.Log("ok, finished waiting for 1s, continuing...");

		while ( true ) { // this is an infinite loop, but it's OK
			Debug.Log("this will print once per second");
			yield return new WaitForSeconds(1f);
		}

		// the code will never reach down here, and the coroutine will never end
	}

}
