using UnityEngine;
using System.Collections;

public class TriggerTouchTheGround : MonoBehaviour {
	public MeshRenderer plane;
	public GameObject nien;
	
	private bool isCatTouchedTheGround = false;
	private bool isAllWorldsCompleted = false;

	void OnTriggerEnter(Collider other){
		
		if(CountDownTimer.instance.GetTimeRemaining() <= 0.0f + 0.004f && PlayerInfo.instance.isHitByObstacles)
		{
			plane.GetComponent<Renderer>().material.color = Color.red;
			Debug.Log ("Changed plain's color to red");
		}
		else if(CountDownTimer.instance.GetTimeRemaining() <= 0.0f + 0.004f && !PlayerInfo.instance.isHitByObstacles)
		{
			plane.GetComponent<Renderer>().material.color = Color.green;
			Debug.Log ("Changed plain's color to green");
		}
		
		// set cat touched the ground
		isCatTouchedTheGround = true;
		
		// play the cat's animation "YAY"
		if(!PlayerInfo.instance.isHitByObstacles)
		{
			nien.GetComponent<Animation>().CrossFade("Section_Complete");
			nien.GetComponent<Animation>().CrossFadeQueued("Idle");
			
			// increase the current number of world
			if(PlayerInfo.instance.currentWorldNumber < GameInfo.instance.totalNumberOfWorld)
			{
				Debug.Log("Increased number of world");
				PlayerInfo.instance.currentWorldNumber++;
			}
			else
			{
				isAllWorldsCompleted = true;
				Debug.Log ("Set isAllWorldsCompleted");
			}
		}
	}
	
	// Get weather the cat touched the ground already
	public bool GetIsCatTouchedTheGround() {
		return isCatTouchedTheGround;
	}
	
	void Update() {
		// if finish playing "Section_Complete" animation
		if(!PlayerInfo.instance.isHitByObstacles && nien.GetComponent<Animation>().IsPlaying("Idle"))
		{
			// if(isAllWorldsCompleted)
			// {
				//Application.LoadLevel(0);
			// }
			// else
			// {
			// 	Application.LoadLevel(PlayerInfo.instance.currentWorldNumber);	// see the number of scene in Build Setting
			// 	Debug.Log("Load next level");
			// }
		}
	}
}
