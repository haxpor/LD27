using UnityEngine;
using System.Collections;

public class GUIGame : MonoBehaviour {

    public GUIStyle timerStyle;
    
    private int timeInMillseconds;

    void OnGUI()
    {
        int sec = (int)((float)timeInMillseconds / 1000F);
        int msec = timeInMillseconds % 1000;
        GUI.TextField(new Rect(Screen.width - 210, 0, 210, 50),
            string.Format("Time To Live: {0:0}:{1:000}", sec, msec  ) , timerStyle);
		GUI.TextField (new Rect(Screen.width - 210, 30, 210, 50),
            string.Format("Ghost trick: " + PlayerInfo.instance.numberOfGhostTrickUsed + " / " + PlayerInfo.instance.numberOfMaximumGhostTrick ) , timerStyle);
    }

    // Use this for initialization
    void Start () {
        timeInMillseconds = 10000;
    }
	
    //// Update is called once per frame
    void Update () {
        timeInMillseconds = (int)(CountDownTimer.instance.timeRemaining * 1000);
    }

    //void UpdateTime(int newTime) { timeInMillseconds = newTime; }
}
