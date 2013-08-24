using UnityEngine;
using System.Collections;

public class TriggerTouchTheGround : MonoBehaviour {
	public MeshRenderer plane;

	void OnTriggerEnter(Collider other){
		plane.renderer.material.color = Color.red;
	}
}
