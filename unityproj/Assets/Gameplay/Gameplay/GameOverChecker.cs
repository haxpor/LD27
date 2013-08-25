using UnityEngine;
using System.Collections; 

public class GameOverChecker : MonoBehaviour {
	public MeshRenderer cat;
	
	public GameObject triggerTouchTheGround;
	
	private TriggerTouchTheGround refTriggerTouchTheGround;

	void Start() {
		// get the reference game objects
		refTriggerTouchTheGround = (TriggerTouchTheGround)triggerTouchTheGround.GetComponent("TriggerTouchTheGround");
	}

	void Update () {
		// GAMEOVER: less than 10 secs, and not touch the ground yet
		if(CountDownTimer.instance.GetTimeRemaining() < 0.0f && !refTriggerTouchTheGround.GetIsCatTouchedTheGround())
		{
			Debug.Log ("Game Over!!");
			cat.material.color = Color.yellow;
			
			// TODO: Add indicator for GAMEOVER HERE ...
		}
	}
}
