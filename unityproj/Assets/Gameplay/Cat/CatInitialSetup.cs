using UnityEngine;
using System.Collections;

public class CatInitialSetup : MonoBehaviour {
	
	void Awake() {
	}
	
	void Start() {
		gameObject.transform.Find("Nien").GetComponent<Animation>()["Freefalling"].speed = 10.0f;
		AudioPlayer.instance.PlayRandomTransitionSfx();
	}
}
