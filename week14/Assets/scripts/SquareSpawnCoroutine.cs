using UnityEngine;
using System.Collections;

public class SquareSpawnCoroutine : MonoBehaviour {

	public Transform thingWeWantToInstantiate;

	void Start () {
		// example of instantiating once, at the beginning of the game
		Instantiate( thingWeWantToInstantiate,
			Random.insideUnitCircle, 
			Quaternion.Euler(0f, 0f, Random.Range(0f, 360f) ) 
		);
		StartCoroutine( ActualSpawnCoroutine() );
	}
	
	IEnumerator ActualSpawnCoroutine () {
		int spawnCount = 0;
		while ( true ) {
			// instantiate once per ___ seconds at a random point in a 10 unit radius circle
			Instantiate( thingWeWantToInstantiate,
				Random.insideUnitCircle * 10f, 
				Quaternion.Euler(0f, 0f, Random.Range(0f, 360f) ) 
			);
			spawnCount++; // keep track of how many times we've spawned, to escalate difficulty
			// you can WaitForSeconds for a random amount of time
			yield return new WaitForSeconds( Random.Range(3f, 5f) / spawnCount );
		}
	}

}
