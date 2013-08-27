using UnityEngine;
using System.Collections;

public class WorldManager : MonoBehaviour {
	
	public AudioClip worldBGM;
	
	void Start () {
		// always reset for a new round
		Time.timeScale = 1.0f;
		Time.fixedDeltaTime = 0.02f;
			
		// play loop audio
		audio.clip = worldBGM;
		audio.loop = true;
		audio.Play();
	}
}
