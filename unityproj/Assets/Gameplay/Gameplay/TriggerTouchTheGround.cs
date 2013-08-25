using UnityEngine;
using System.Collections;

public class TriggerTouchTheGround : MonoBehaviour {
	public MeshRenderer plane;
	public GameObject gameOverChecker;
	
	private bool isCatTouchedTheGround = false;

	void OnTriggerEnter(Collider other){
		plane.renderer.material.color = Color.red;
		
		// set cat touched the ground
		isCatTouchedTheGround = true;
	}
	
	// Get weather the cat touched the ground already
	public bool GetIsCatTouchedTheGround() {
		return isCatTouchedTheGround;
	}
}
