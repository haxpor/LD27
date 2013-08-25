using UnityEngine;
using System.Collections;

public class GUIGameWin : MonoBehaviour {

    public float scaleVal1;
    public float scaleTime1;
    public float scaleVal2;
    public float scaleTime2;
    public float scaleVal3;
    public float scaleValPulse;
    public float scaleTimePulse;

	// Use this for initialization
	void Start () {

        transform.parent = Camera.main.transform;
        gameObject.transform.localPosition = new Vector3(0, 0, 4);
        gameObject.transform.localRotation = new Quaternion();
        gameObject.transform.localScale = new Vector3(scaleVal1, scaleVal1, scaleVal1);

        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(scaleVal2, scaleVal2, scaleVal2),
            "time", scaleTime1,
            "easeType", "easeInQuad"));
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(scaleVal3, scaleVal3, scaleVal3),
            "delay", scaleTime1,
            "time", scaleTime2,
            "easeType", "easeOutQuad",
            "onComplete", "Start2" ));
    }
    void Start2()
    {
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(scaleValPulse, scaleValPulse, scaleValPulse),
            "time", scaleTimePulse,
            "easeType", "easeInOutQuad",
            "loopType", iTween.LoopType.pingPong));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
