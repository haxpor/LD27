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
		}
		else if(Input.GetButtonDown("SpeedUp"))
		{
			Time.timeScale = 3.0f;
		}
		else if(Input.GetButtonUp("GhostTrick"))
		{
			Time.timeScale = 1.0f;
		}
	}
}
