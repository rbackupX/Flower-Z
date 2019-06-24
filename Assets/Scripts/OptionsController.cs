using UnityEngine;
using System.Collections;
using UnityEngine.UI; /* imported to use for ui elements like sliders*/

public class OptionsController : MonoBehaviour {
	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
	public MusicManager musicManager;
	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager> ();  
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.SetVolume (volumeSlider.value);
	}
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);    /* save the value of sliders*/
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
		levelManager.LoadLevel ("01a Start");
	}
	public void SetDefaults(){
		volumeSlider.value = 0.8f;
		difficultySlider.value = 2;
	}
}
