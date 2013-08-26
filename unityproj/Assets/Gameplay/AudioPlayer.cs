using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour {
	
	public AudioClip[] hurt_sfx;
	public AudioClip[] lose_sfx;
	public AudioClip[] win_sfx;
	public AudioClip[] transition_sfx;
	
	public static AudioPlayer instance { get; private set; }
	
	void Awake() {
		instance = this;
		DontDestroyOnLoad(instance);
	}

	public void PlayRandomHurtSfx() {
		audio.PlayOneShot(hurt_sfx[Random.Range(0, hurt_sfx.Length)]);
	}
	
	public void PlayRandomLoseSfx() {
		audio.PlayOneShot(lose_sfx[Random.Range(0, lose_sfx.Length)]);
	}
	
	public void PlayRandomWinSfx() {
		audio.PlayOneShot(win_sfx[Random.Range(0, win_sfx.Length)]);
	}
	
	public void PlayRandomTransitionSfx() {
		audio.PlayOneShot(transition_sfx[Random.Range (0, transition_sfx.Length)]);
	}
}
