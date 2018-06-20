using UnityEngine;
using System.Collections;

public class HitEffect : MonoBehaviour {
	public Transform camera;
	
	private float preV;

	// Use this for initialization
	void Start () {
		preV = gameObject.GetComponent<Rigidbody>().velocity.y;
	}
	
	// Update is called once per frame
	void Update () {
		// solve the issue of mesh-collider has no easy way to automatic check for collision detection
		// check when hit with non-mesh collider (as we need to manually check this)
		//Debug.Log("vel-y: " + gameObject.rigidbody.velocity.y);
		if(CountDownTimer.instance.GetTimeRemaining() > 0.0f && gameObject.GetComponent<Rigidbody>().velocity.y > preV && !PlayerInfo.instance.isHitByObstacles)
		{
			Hit();
		}
		
		// update previous velocity-y
		preV = gameObject.GetComponent<Rigidbody>().velocity.y;
	}
	
	// simple collision checker
	void OnCollisionEnter(Collision collision) {
		string tag = collision.collider.gameObject.tag;
		if(tag == "Obstacles")
		{
			Hit();
		}
	}
	
	void Hit() {
		Debug.Log ("Cat is collided with one of obstacles");
			
		AudioPlayer.instance.PlayRandomHurtSfx();
		
		// set hit flag
		PlayerInfo.instance.isHitByObstacles = true;
		
		// disable rigidbody
		//gameObject.rigidbody.isKinematic = true;
		// apply screen shaking
		iTween.ShakePosition(Camera.main.gameObject, new Vector3(2, 2, 2), 1.0f);
	}
}
