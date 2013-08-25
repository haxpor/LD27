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
	
	public float xAxisForce = 100.0f;
	public float zAxisForce = 100.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Left"))
		{
			// add force
			cat.AddForce(-cat.transform.right * xAxisForce, ForceMode.Impulse);
		}
		if(Input.GetButtonDown("Right"))
		{
			// add force
			cat.AddForce(cat.transform.right * xAxisForce, ForceMode.Impulse);
		}
		if(Input.GetButtonDown("Up"))
		{
			// add force
			cat.AddForce(cat.transform.forward * zAxisForce, ForceMode.Impulse);
		}
		if(Input.GetButtonDown("Down"))
		{
			// add force
			cat.AddForce(-cat.transform.forward * zAxisForce, ForceMode.Impulse);
		}
	}
}
