using UnityEngine;
using System.Collections;

public class TriggerTouchTheGround : MonoBehaviour {
	public MeshRenderer plane;
	public GameObject nien;
	
	private bool isCatTouchedTheGround = false;

	void OnTriggerEnter(Collider other){
		
		if(CountDownTimer.instance.GetTimeRemaining() <= 0.0f || PlayerInfo.instance.isHitByObstacles)
			plane.renderer.material.color = Color.red;
		else if(!PlayerInfo.instance.isHitByObstacles)
			plane.renderer.material.color = Color.green;
		
		// set cat touched the ground
		isCatTouchedTheGround = true;
		
		// play the cat's animation "YAY"
		if(!PlayerInfo.instance.isHitByObstacles)
			nien.animation.CrossFade("Section_Complete");
	}
	
	// Get weather the cat touched the ground already
	public bool GetIsCatTouchedTheGround() {
		return isCatTouchedTheGround;
	}
}
