using UnityEngine;
using System.Collections;

public class MovementControl : MonoBehaviour {
	// note: adhere to the following coordinate
	//			+z
	//			 |
	//			 |
	//			 |
	// +x---------
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
			cat.AddForce(-cat.transform.right * xAxisForce, ForceMode.Force);
		}
		if(Input.GetButton("Right"))
		{
			// add force
			cat.AddForce(cat.transform.right * xAxisForce, ForceMode.Force);
		}
		if(Input.GetButton("Up"))
		{
			// add force
			cat.AddForce(cat.transform.forward * zAxisForce, ForceMode.Force);
		}
		if(Input.GetButton("Down"))
		{
			// add force
			cat.AddForce(-cat.transform.forward * zAxisForce, ForceMode.Force);
		}
	}
}
