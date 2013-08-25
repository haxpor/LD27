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
		
		// play the cat's animation "YAY"
		GameObject.Find("Nien").animation.Play("Section_Complete");
	}
	
	// Get weather the cat touched the ground already
	public bool GetIsCatTouchedTheGround() {
		return isCatTouchedTheGround;
	}
}
