using UnityEngine;
using System.Collections;

public class PlayBGM : MonoBehaviour {

	public AudioClip titleBGM;
	
	void Start () {
		// play loop audio
		audio.clip = titleBGM;
		audio.loop = true;
		audio.Play();
	}
}
