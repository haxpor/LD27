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
		if(Input.GetButton("Left"))
		{
			// add force
			cat.AddForce(new Vector3(-1.0f, 0.0f, 0.0f) * xAxisForce, ForceMode.Acceleration);
		}
		if(Input.GetButton("Right"))
		{
			// add force
			cat.AddForce(new Vector3(1.0f, 0.0f, 0.0f) * xAxisForce, ForceMode.Acceleration);
		}
		if(Input.GetButton("Up"))
		{
			// add force
			cat.AddForce(new Vector3(0.0f, 0.0f, 1.0f) * zAxisForce, ForceMode.Acceleration);
		}
		if(Input.GetButton("Down"))
		{
			// add force
			cat.AddForce(new Vector3(0.0f, 0.0f, -1.0f) * zAxisForce, ForceMode.Acceleration);
		}
	}
}
