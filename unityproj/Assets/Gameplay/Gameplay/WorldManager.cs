using UnityEngine;
using System.Collections;

public class WorldManager : MonoBehaviour {
	
	public AudioClip worldBGM;
	
	void Start () {
		// play loop audio
		audio.clip = worldBGM;
		audio.loop = true;
		audio.Play();
	}
}
