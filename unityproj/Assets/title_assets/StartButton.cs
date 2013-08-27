using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	public Texture2D titleTex;
	public GUIStyle customButtonStyle;

	void OnGUI () {
		// Make a background box
		// GUI.Box(new Rect(10,10,100,90), "Loader Menu");
		GUI.DrawTexture(new Rect(
				(Screen.width-titleTex.width)*0.5f, 
				(Screen.height*0.25f)-titleTex.height*0.5f,  // -customButtonStyle.normal.background.height
				titleTex.width, titleTex.height),
			titleTex);

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect( 
				(Screen.width-customButtonStyle.normal.background.width)*0.5f, 
				(Screen.height)*0.5f,  // -customButtonStyle.normal.background.height
				customButtonStyle.normal.background.width, customButtonStyle.normal.background.height),
			"", customButtonStyle)) {
		//if(GUILayout.Button(customButtonStyle.normal.background)) {
			
			AudioPlayer.instance.PlayRandomStartSfx();
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
