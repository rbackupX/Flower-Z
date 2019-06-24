using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public float fadeInTime;

	private Image fadePanel;
	private Color currentColor = Color.black;
	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image> (); /* gets the panel image */
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad< fadeInTime) {
			// Fade in
			float alphaChange = Time.deltaTime / fadeInTime;     /*deltaTime -->the time in seconds it took to complete the last frame */
			currentColor.a -= alphaChange;						
			fadePanel.color = currentColor;
		} else {
			gameObject.SetActive(false);
		}
	}
}
