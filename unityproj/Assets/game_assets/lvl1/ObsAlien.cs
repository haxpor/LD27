using UnityEngine;
using System.Collections;

public class ObsAlien : MonoBehaviour {

    public float angularSpeed;
    public float radius;

    private Vector3 center;
    private float currAngle;
    private Transform alienTransform;

	// Use this for initialization
	void Start () {

        alienTransform = gameObject.transform.FindChild("Alien");

        // rotate ufo locally
        Transform t = alienTransform.FindChild("ufo").transform;
        t.Rotate(new Vector3(0,0,1), Random.Range(0.0f, 360.0f));
        t.Rotate(new Vector3(1, 0, 0), Random.Range(0.0f, 10.0f));

        // randomize currAngle and push alien away from center (gameObject.transform) at angle
        currAngle = Random.Range(0.0f, 360.0f);
        alienTransform.localPosition = new Vector3(radius * Mathf.Cos(currAngle), 0.0f, radius * Mathf.Sin(currAngle));
		
	}
	
	// Update is called once per frame
	void Update () {
    	currAngle += angularSpeed * Time.deltaTime;
    	Vector3 newPos = new Vector3(radius * Mathf.Cos(currAngle), 0.0f, radius * Mathf.Sin(currAngle));
    	alienTransform.Translate(newPos - alienTransform.localPosition);
	}
}
