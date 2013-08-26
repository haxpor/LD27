using UnityEngine;
using System.Collections;

public class HitEffect : MonoBehaviour {
	public Transform camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// simple collision checker
	void OnCollisionEnter(Collision collision) {
		if(collision.collider.gameObject.tag == "Obstacles")
		{
			Debug.Log ("Cat is collided with one of obstacles");
			
			// set hit flag
			PlayerInfo.instance.isHitByObstacles = true;
			
			// disable rigidbody
			//gameObject.rigidbody.isKinematic = true;
			// apply screen shaking
			iTween.ShakePosition(Camera.main.gameObject, new Vector3(2, 2, 2), 1.0f);
		}
	}
}
