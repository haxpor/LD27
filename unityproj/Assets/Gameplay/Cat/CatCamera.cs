using UnityEngine;
using System.Collections;

public class CatCamera : MonoBehaviour {
	
	public Transform camera;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// make the camera a little bit above the cat
		camera.position = new Vector3(camera.position.x, transform.position.y + 10, transform.position.z);
		camera.position = Vector3.Lerp(camera.position, transform.position, 0.65f);
	}
}
