using UnityEngine;
using System.Collections;

public class ObsMeteor : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        Debug.Log("Child" + gameObject.transform.GetChild(0).name);
        gameObject.transform.GetChild(0).transform.rotation = Random.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(0, -speed, 0, Space.World);
	}
}
