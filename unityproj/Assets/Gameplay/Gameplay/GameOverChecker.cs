using UnityEngine;
using System.Collections; 

public class GameOverChecker : MonoBehaviour {
	public MeshRenderer cat;
	
	public GameObject triggerTouchTheGround;
    public Transform gameLosePrefab;
    public Transform gameWinPrefab;
	
	private TriggerTouchTheGround refTriggerTouchTheGround;
	private bool isGameOverStateReached = false;

    void Start() {
		// get the reference game objects
		refTriggerTouchTheGround = (TriggerTouchTheGround)triggerTouchTheGround.GetComponent("TriggerTouchTheGround");
		isGameOverStateReached = false;
	}

	void Update () {
		if(!isGameOverStateReached)
		{
			// GAMEOVER: less than 10 secs, and not touch the ground yet
			if((CountDownTimer.instance.GetTimeRemaining() <= 0.0f + 0.002f && PlayerInfo.instance.isHitByObstacles) || PlayerInfo.instance.isHitByObstacles)
			{
				Debug.Log ("Game Over!!");
				cat.material.color = Color.yellow;
				
				// Send message for GAMEOVER
	            //gameObject.BroadcastMessage("onGameOver", SendMessageOptions.RequireReceiver);
	            Instantiate(gameLosePrefab);
				
				isGameOverStateReached = true;
				
				AudioPlayer.instance.PlayRandomLoseSfx();
			}
			else if(CountDownTimer.instance.GetTimeRemaining() <= 0.0f + 0.002f && !PlayerInfo.instance.isHitByObstacles)
			{
				Debug.Log ("Win!!");
				cat.material.color = Color.green;
				
				// Send message for WINNING 
	            //gameObject.BroadcastMessage("onWin", SendMessageOptions.RequireReceiver);
	            Instantiate(gameWinPrefab);
				
				isGameOverStateReached = true;
				
				AudioPlayer.instance.PlayRandomWinSfx();
			}
		}
	}
}
