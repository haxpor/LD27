using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {
	public int numberOfMaximumGhostTrick = 10;	// don't edit this value
	public int numberOfGhostTrickUsed = 10;
	public bool isHitByObstacles = false;
	
	public static PlayerInfo instance { get; private set; }

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
