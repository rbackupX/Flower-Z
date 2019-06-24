using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	public void Start(){
		if (autoLoadNextLevelAfter <= 0) {
			Debug.Log ("Level auto-load is disabled, use a positive number in seconds.");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);   /* the line get to the other level */
		}
	}
	public void LoadLevel(string name){					/*which level will be loaded */
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);

	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
