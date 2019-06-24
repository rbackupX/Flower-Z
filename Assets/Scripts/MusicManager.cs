using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray; /* keeps track of levels to play different musics in different levels */
	private AudioSource audioSource;
	void Awake(){
		DontDestroyOnLoad (gameObject); /* to keep persistent music player working in every scene */
		Debug.Log ("Don't Destroy on Load " + name);
	}

	void Start(){
		audioSource = GetComponent<AudioSource> ();
	}
	void OnLevelWasLoaded(int level){
		AudioClip thisLevelMusic = levelMusicChangeArray [level]; 
		Debug.Log ("music level : " + thisLevelMusic);
		if(thisLevelMusic) 
		{
			audioSource.clip=thisLevelMusic;
			audioSource.loop=true;
			audioSource.Play();
		}
	}
	public void SetVolume(float volumeLevel){
		audioSource.volume = volumeLevel;
	}
	
}
