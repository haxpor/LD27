using UnityEngine;
using System.Collections; 

public class GameOverChecker : MonoBehaviour {
	public MeshRenderer cat;
	
	public GameObject triggerTouchTheGround;
	public GameObject countDownTimer;
	
	private TriggerTouchTheGround refTriggerTouchTheGround;
	private CountDownTimer refCountDownTimer;
	
	void Start() {
		// get the reference game objects
		refTriggerTouchTheGround = (TriggerTouchTheGround)triggerTouchTheGround.GetComponent("TriggerTouchTheGround");
		refCountDownTimer = (CountDownTimer)countDownTimer.GetComponent("CountDownTimer");
	}

	void Update () {
		// GAMEOVER: less than 10 secs, and not touch the ground yet
		if(refCountDownTimer.GetTimeRemaining() < 0.0f && !refTriggerTouchTheGround.GetIsCatTouchedTheGround())
		{
			Debug.Log ("Game Over!!");
			cat.material.color = Color.yellow;
			
			// TODO: Add indicator for GAMEOVER HERE ...
		}
	}
}
