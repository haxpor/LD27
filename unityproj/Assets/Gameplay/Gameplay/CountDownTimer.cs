using UnityEngine;
using System.Collections;

public class CountDownTimer : MonoBehaviour {
	
	public float timeRemaining = 10.0f;

    public static CountDownTimer instance { get; private set; }

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        if (timeRemaining > 0.0f && !PlayerInfo.instance.isHitByObstacles)
            timeRemaining -= Time.deltaTime;
        else if(!PlayerInfo.instance.isHitByObstacles)
            timeRemaining = 0.0f;
	}
	
	void ResetTimer() {
		timeRemaining = 0.0f;
	}
	
	public float GetTimeRemaining() {
		return timeRemaining;
	}
}
