using UnityEngine;
using System.Collections;

public class SetUpWorld : MonoBehaviour {
	
	public int worldNumber = 1;
	public AudioClip world1_music;

	// Use this for initialization
	void Start () {
		switch(worldNumber)
		{
		case 1:
			audio.clip = world1_music;
			audio.loop = true;
			audio.Play();
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
