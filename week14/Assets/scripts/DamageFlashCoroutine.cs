using UnityEngine;
using System.Collections;

public class DamageFlashCoroutine : MonoBehaviour {

	public SpriteRenderer myPlayerSprite;

	void Update () {
		// debug test: press SPACE to test the damage flash effect
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			StartCoroutine( Damage(4) );
		}
	}

	IEnumerator Damage ( int flashCountMax) {
		// use a FOR loop to repeat the flash several times
		for ( int flashCount=0; flashCount < flashCountMax; flashCount++ ) {
			myPlayerSprite.color = new Color( 1f, 0f, 0f ); // turn red
			yield return new WaitForSeconds( 0.1f); // pause
			myPlayerSprite.color = new Color( 1f, 1f, 1f ); // turn white
			yield return new WaitForSeconds( 0.1f); // pause

			// let's say you wanted to end a coroutine early?
			if ( flashCount == 3 ) {
				yield break; // "yield break" ends a coroutine early
			}
		}
	}

}
