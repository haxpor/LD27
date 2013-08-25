using UnityEngine;
using System.Collections;

public class GUIGameOver : MonoBehaviour {

    public float scaleVal1;
    public float scaleValPulse;
    public float scaleTimePulse;

	// Use this for initialization
	void Start () {

        transform.parent = Camera.main.transform;
        gameObject.transform.localPosition = new Vector3(0, 0, 4);
        gameObject.transform.localRotation = new Quaternion();
        gameObject.transform.localScale = new Vector3(scaleVal1, scaleVal1, scaleVal1);
        
        iTween.MoveTo(gameObject, iTween.Hash("y", 0, "time", 3, "islocal", true));

        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(scaleValPulse, scaleValPulse, scaleValPulse),
            "time", scaleTimePulse,
            "easeType", "easeInOutQuad",
            "loopType", iTween.LoopType.pingPong) );
	}
	
	// Update is called once per frame
    //void Update () {
    //}

    public GUIStyle retryLevelStyle;
    public GUIStyle titleStyle;
    void OnGUI()
    {
        float y = Screen.height / 2 + 70;
        if (GUI.Button(new Rect((Screen.width - 200) / 2, y, 200, 50), "Retry Level", retryLevelStyle))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        y += 50 + 5;
        if (GUI.Button(new Rect((Screen.width - 200) / 2, y, 200, 50), "Title", titleStyle))
        {
            Application.LoadLevel(0);
        }
    }
}
