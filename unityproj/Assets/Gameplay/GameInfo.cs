using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {
	
	public int totalNumberOfWorld = 2;
	
	public static GameInfo instance { get; private set; }

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
