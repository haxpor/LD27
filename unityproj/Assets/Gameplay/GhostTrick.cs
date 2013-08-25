using UnityEngine;
using System.Collections;

public class GhostTrick : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("GhostTrick"))
		{
            Time.timeScale = 0.2f;
            // If you lower timeScale it is recommended to also lower Time.fixedDeltaTime by the same amount.
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
            gameObject.BroadcastMessage("GhostTrickOn");
		}
        else if (Input.GetButtonUp("GhostTrick"))
        {
            Time.timeScale = 1.0f;
            // If you lower timeScale it is recommended to also lower Time.fixedDeltaTime by the same amount.
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
            gameObject.BroadcastMessage("GhostTrickOff");
        }
		else if(Input.GetButtonDown("SpeedUp"))
		{
            Time.timeScale = 3.0f;
            // If you lower timeScale it is recommended to also lower Time.fixedDeltaTime by the same amount.
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
            gameObject.BroadcastMessage("SpeedUpOn");
		}
        else if (Input.GetButtonUp("SpeedUp"))
        {
            Time.timeScale = 1.0f;
            // If you lower timeScale it is recommended to also lower Time.fixedDeltaTime by the same amount.
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
            gameObject.BroadcastMessage("SpeedUpOff");
        }
		
	}
}
