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
		if(timeRemaining > 0.0f)
			timeRemaining -= Time.deltaTime;
	}
	
	void ResetTimer() {
		timeRemaining = 0.0f;
	}
}
