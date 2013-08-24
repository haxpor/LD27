using UnityEngine;
using System.Collections;

public class CatCamera : MonoBehaviour {
	
	public Transform catTransform;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// make the camera a little bit above the cat
		transform.position = new Vector3(catTransform.position.x, catTransform.position.y + 10, catTransform.position.z);
		transform.position = Vector3.Lerp(transform.position, catTransform.position, 0.65f);
	}
}
