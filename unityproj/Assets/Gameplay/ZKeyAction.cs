using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZKeyAction : MonoBehaviour {

	public GameObject enableOnZUp;
	public GameObject enableOnZDown;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Z))
		{
			AudioPlayer.instance.PlayRandomMoveSfx();
		}
		if(Input.GetKey(KeyCode.Z))
		{
			enableOnZDown.SetActive(true);
			enableOnZUp.SetActive(false);
		}
		else
		{
			enableOnZDown.SetActive(false);
			enableOnZUp.SetActive(true);
		}
	}
}
