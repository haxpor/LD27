using UnityEngine;
using System.Collections;

public class CatCamera : MonoBehaviour {
	
	public Transform camera;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(!PlayerInfo.instance.isHitByObstacles)
		{
			// lerp individual position
			// y
			float y = Mathf.Lerp(camera.position.y + 15, transform.position.y, 0.65f);
			camera.position = new Vector3(camera.position.x, y, 0.0f);
		}
	}
}
