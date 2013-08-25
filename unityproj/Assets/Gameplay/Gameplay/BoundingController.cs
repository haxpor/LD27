using UnityEngine;
using System.Collections;

public class BoundingController : MonoBehaviour {
	public Rigidbody cat;
	public GameObject levelManager;
	public float boundaryBouncingBackForce = 500.0f;
	
	private float boundingHalfWidth;

	// Use this for initialization
	void Start () {
		// set the bounding half width from level 
		ObstacleManager obsManager = (ObstacleManager)levelManager.GetComponent("ObstacleManager");
		boundingHalfWidth = obsManager.spawnHalfWidth;
		Debug.Log (boundingHalfWidth);
	}
	
	// Update is called once per frame
	void Update () {
		// simple bounding
		if(cat.transform.position.x < -boundingHalfWidth)
			cat.AddForce(boundaryBouncingBackForce, 0.0f, 0.0f, ForceMode.Force);
		else if(cat.transform.position.x > boundingHalfWidth)
			cat.AddForce(-boundaryBouncingBackForce, 0.0f, 0.0f, ForceMode.Force);
		
		if(cat.transform.position.z < -boundingHalfWidth)
			cat.AddForce(0.0f, 0.0f, boundaryBouncingBackForce, ForceMode.Force);
		else if(cat.transform.position.z > boundingHalfWidth)
			cat.AddForce(0.0f, 0.0f, -boundaryBouncingBackForce, ForceMode.Force);
	}
}
