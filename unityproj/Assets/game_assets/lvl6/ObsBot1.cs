using UnityEngine;
using System.Collections;

public class ObsBot1 : MonoBehaviour {

	private float[] rotationRandom = {0, 90, 180, 270};
	
	// Use this for initialization
	void Start () {
		// initial random the rotation abit to make it looks different
		gameObject.transform.rotation = Quaternion.Euler(rotationRandom[Random.Range(0,4)], rotationRandom[Random.Range(0,4)], rotationRandom[Random.Range(0,4)]);
		gameObject.collider.transform.rotation = gameObject.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
