using UnityEngine;
using System.Collections;

public class ObsBieberFan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// initial random the rotation abit to make it looks different
		gameObject.transform.rotation = Quaternion.Euler(0, Random.Range(0,360), 0);
	}
	
	// Update is called once per frame
	void Update () {
		iTween.RotateBy(gameObject, iTween.Hash("amount", new Vector3(0.0f, 1.0f, 0.0f), "speed", 3.0f));
	}
}
