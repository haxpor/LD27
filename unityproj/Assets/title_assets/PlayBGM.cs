using UnityEngine;
using System.Collections;

public class PlayBGM : MonoBehaviour {

	public AudioClip titleBGM;
	
	void Start () {
		// play loop audio
		GetComponent<AudioSource>().clip = titleBGM;
		GetComponent<AudioSource>().loop = true;
		GetComponent<AudioSource>().Play();
	}
}
