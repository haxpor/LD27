using UnityEngine;
using System.Collections;

public class GhostTrick : MonoBehaviour {
	public float ghostTrickSlowTimeScale = 0.2f;
	public float ghostTrickActiveDuration = 0.6f;	// in secs
	public int numberOfGhostTrickUsed = 10;
	
	private float ghostTrickCountingTimeActiveDuration = 0.0f;
	private bool isGhostTrickActivated = false;
	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("GhostTrick") && !isGhostTrickActivated && numberOfGhostTrickUsed > 0)
		{
			numberOfGhostTrickUsed--;
			isGhostTrickActivated = true;
			
            Time.timeScale = ghostTrickSlowTimeScale;
            // If you lower timeScale it is recommended to also lower Time.fixedDeltaTime by the same amount.
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
            gameObject.BroadcastMessage("GhostTrickOn", SendMessageOptions.DontRequireReceiver);
		}
		
		// counting down time
		if(isGhostTrickActivated)
		{
			ghostTrickCountingTimeActiveDuration += Time.deltaTime;
			Debug.Log ("Ghosttrick time: " + ghostTrickCountingTimeActiveDuration);
			
			// if reach the active duration then go back to normal
			if(ghostTrickCountingTimeActiveDuration >= ghostTrickActiveDuration)
			{
				Debug.Log ("entered");
				
				// reset states
				isGhostTrickActivated = false;
				ghostTrickCountingTimeActiveDuration = 0.0f;
				
				Time.timeScale = 1.0f;
				
	            // If you lower timeScale it is recommended to also lower Time.fixedDeltaTime by the same amount.
	            Time.fixedDeltaTime = 0.02F * Time.timeScale;
	            gameObject.BroadcastMessage("GhostTrickOff", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
