using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	void OnGUI () {
		// Make a background box
		// GUI.Box(new Rect(10,10,100,90), "Loader Menu");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		Resolution r = Screen.currentResolution;
		if(GUI.Button(new Rect( (r.width-80)*0.5f, (r.height-20)*0.5f ,80,20), "Start")) {
			Application.LoadLevel(1);
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
