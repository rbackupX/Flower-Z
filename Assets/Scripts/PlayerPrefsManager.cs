using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY = "diffulty";
	const string LEVEL_KEY = "level_unlocked_";


	public static void SetMasterVolume(float volume){
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("master volume out of range");
		}
	}
	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}
	public static void UnlockLevel(int level){
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1);		/* we use 1 for true */
		} else {
			Debug.LogError("Trying to unlock level not in build order");
		}
	}
	public static bool IsLevelUnlocked(int level){
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);
		if (level <= Application.levelCount - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError ("false error ");
			return false;
		}
	
	}
	public static void SetDifficulty(float difficulty){
		if (difficulty >= 1f && difficulty <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY, difficulty);
		} else {
			Debug.LogError("you can't exceed the difficulty over 3 or less than 1");
		}
	}
	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat (DIFFICULTY);
	}
}
