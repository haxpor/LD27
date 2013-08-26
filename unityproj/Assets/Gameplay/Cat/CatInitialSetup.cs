using UnityEngine;
using System.Collections;

public class CatInitialSetup : MonoBehaviour {
	
	void Awake() {
	}
	
	void Start() {
		gameObject.transform.FindChild("Nien").animation["Freefalling"].speed = 10.0f;
	}
}
