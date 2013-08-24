using UnityEngine;
using System.Collections;

public class CatInitialSetup : MonoBehaviour {
	public MeshRenderer cat;
	
	void Awake() {
		cat.material.color = Color.blue;
	}
}
