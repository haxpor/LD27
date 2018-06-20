using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour {
	
	public AudioClip[] hurt_sfx;
	public AudioClip[] lose_sfx;
	public AudioClip[] win_sfx;
	public AudioClip[] transition_sfx;
	public AudioClip ghostTrickDrag_sfx;
	public AudioClip ghostTrickStart_sfx;
	public AudioClip ghostTrickEnd_sfx;
	public AudioClip[] move_sfx;
	public AudioClip[] start_sfx;
	
	public static AudioPlayer instance { get; private set; }
	
	void Awake() {
		instance = this;
		DontDestroyOnLoad(instance);
	}

	public void PlayRandomHurtSfx() {
		GetComponent<AudioSource>().PlayOneShot(hurt_sfx[Random.Range(0, hurt_sfx.Length)]);
	}
	
	public void PlayRandomLoseSfx() {
		GetComponent<AudioSource>().PlayOneShot(lose_sfx[Random.Range(0, lose_sfx.Length)]);
	}
	
	public void PlayRandomWinSfx() {
		GetComponent<AudioSource>().PlayOneShot(win_sfx[Random.Range(0, win_sfx.Length)]);
	}
	
	public void PlayRandomTransitionSfx() {
		GetComponent<AudioSource>().PlayOneShot(transition_sfx[Random.Range (0, transition_sfx.Length)]);
	}
	
	public void PlayGhostTrickStartSfx() {
		GetComponent<AudioSource>().pitch = 0.9f;
		GetComponent<AudioSource>().PlayOneShot(ghostTrickStart_sfx);
		GetComponent<AudioSource>().pitch = 1.0f;
	}
	
	public void PlayGhostTrickEndSfx() {
		GetComponent<AudioSource>().PlayOneShot(ghostTrickEnd_sfx);
	}
	
	public void PlayGhostTrickDragSfx() {
		GetComponent<AudioSource>().pitch = 0.9f;
		GetComponent<AudioSource>().PlayOneShot(ghostTrickDrag_sfx);
		GetComponent<AudioSource>().pitch = 1.0f;
	}
	
	public void PlayRandomMoveSfx() {
		GetComponent<AudioSource>().PlayOneShot(move_sfx[Random.Range (0, move_sfx.Length)]);
	}
	
	public void PlayRandomStartSfx() {
		GetComponent<AudioSource>().PlayOneShot(start_sfx[Random.Range(0, start_sfx.Length)]);
	}
}
