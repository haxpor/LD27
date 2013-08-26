using UnityEngine;
using System.Collections;

public class TriggerTouchTheGround : MonoBehaviour {
	public MeshRenderer plane;
	public GameObject nien;
	
	private bool isCatTouchedTheGround = false;

	void OnTriggerEnter(Collider other){
		
		if(CountDownTimer.instance.GetTimeRemaining() <= 0.0f)
			plane.renderer.material.color = Color.red;
		else
			plane.renderer.material.color = Color.green;
		
		// set cat touched the ground
		isCatTouchedTheGround = true;
		
		// play the cat's animation "YAY"
		nien.animation.Play("Section_Complete");
	}
	
	// Get weather the cat touched the ground already
	public bool GetIsCatTouchedTheGround() {
		return isCatTouchedTheGround;
	}
}
