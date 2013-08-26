using UnityEngine;
using System.Collections;

public class ObsMeteor : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        gameObject.transform.GetChild(0).transform.rotation = Random.rotation;
	}
	
	// Update is called once per frame
	void Update () {
    	gameObject.transform.Translate(0, -speed * Time.deltaTime, 0, Space.World);
        if (gameObject.transform.position.y <= -50)
        {
            gameObject.SetActive(false);
            if(ObjectPool.instance)
                ObjectPool.instance.PoolObject(gameObject);
        }
	}
}
