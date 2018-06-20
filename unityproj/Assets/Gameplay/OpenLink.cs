using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour {

	public string link;

	// Use this for initialization
	public void Open () {
        Application.ExternalEval("window.open(\"" + link + "\",\"_blank\")");
    }
	
}
