using UnityEngine;
using System.Collections;

public class ObsRocket : MonoBehaviour {

	public float angularSpeed;
    public float radius;

    private Vector3 center;
    private float currAngle;
    private Transform transform;

	// Use this for initialization
	void Start () {

        transform = gameObject.transform.FindChild("rocket");
		
		Debug.Log ("Rotation X: " + transform.rotation.x);

        // rotate ufo locally
        Transform t = transform;
        t.Rotate(new Vector3(0,0,1), Random.Range(0.0f, 360.0f));
        t.Rotate(new Vector3(1, 0, 0), Random.Range(0.0f, 10.0f));

        // randomize currAngle and push alien away from center (gameObject.transform) at angle
        currAngle = Random.Range(0.0f, 360.0f);
        transform.localPosition = new Vector3(radius * Mathf.Cos(currAngle), 0.0f, radius * Mathf.Sin(currAngle));
	}
	
	// Update is called once per frame
	void Update () {
        currAngle += angularSpeed * Time.deltaTime;
        Vector3 newPos = new Vector3(radius * Mathf.Cos(currAngle), 0.0f, radius * Mathf.Sin(currAngle));
        transform.Translate(newPos - transform.localPosition);
	}
}
