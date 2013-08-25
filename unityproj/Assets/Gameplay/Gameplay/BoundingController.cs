using UnityEngine;
using System.Collections;

public class BoundingController : MonoBehaviour {
	public Rigidbody cat;
	public GameObject levelManager;
	public float boundaryBouncingBackForce = 1.0f;
	
	private float boundingHalfWidth;
	private float boundingHalfHeight;

	// Use this for initialization
	void Start () {
		// set the bounding half width from level 
		ObstacleManager obsManager = (ObstacleManager)levelManager.GetComponent("ObstacleManager");
		boundingHalfWidth = obsManager.spawnHalfWidth * 0.25f;
		boundingHalfHeight = obsManager.spawnHalfHeight * 0.80f;
	}
	
	// Update is called once per frame
	void Update () {
		// simple bounding
		if(cat.transform.position.x < -boundingHalfWidth)
			cat.velocity = new Vector3(0.0f, cat.velocity.y, cat.velocity.z);
		else if(cat.transform.position.x > boundingHalfWidth)
			cat.velocity = new Vector3(0.0f, cat.velocity.y, cat.velocity.z);
		
		if(cat.transform.position.z < -boundingHalfHeight)
			cat.velocity = new Vector3(cat.velocity.x, cat.velocity.y, 0.0f);
		else if(cat.transform.position.z > boundingHalfHeight)
			cat.velocity = new Vector3(cat.velocity.x, cat.velocity.y, 0.0f);
	}
}
