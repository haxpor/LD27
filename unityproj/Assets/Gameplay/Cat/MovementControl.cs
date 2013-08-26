using UnityEngine;
using System.Collections;

public class MovementControl : MonoBehaviour {
	// note: adhere to the following coordinate
	//			+z
	//			 |
	//			 |
	//			 |
	// -x---------
	// for each key press and movement
	
	public Rigidbody cat;
	
	public float xAxisForce = 500.0f;
	public float zAxisForce = 500.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(CountDownTimer.instance.GetTimeRemaining() > 0.0f)
		{
			if(Input.GetButton("Left"))
			{
				// add force
				iTween.MoveBy(gameObject, iTween.Hash("x", -2, "time", 0.35));
			}
			if(Input.GetButton("Right"))
			{
				// add force
				iTween.MoveBy(gameObject, iTween.Hash("x", 2, "time", 0.35));
			}
			if(Input.GetButton("Up"))
			{
				// add force
				iTween.MoveBy(gameObject, iTween.Hash("z", 2, "time", 0.35));
			}
			if(Input.GetButton("Down"))
			{
				// add force
				iTween.MoveBy(gameObject, iTween.Hash("z", -2, "time", 0.35));
			}
		}
	}
}
