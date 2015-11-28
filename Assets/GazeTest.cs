using UnityEngine;
using System.Collections;

public class GazeTest : MonoBehaviour {

    private CardboardHead gazeTestHead;

	// Use this for initialization
	void Start () {
        gazeTestHead = GameObject.FindObjectOfType<CardboardHead>();
	}
	
	// Update is called once per frame
	void Update () {
	    print(gazeTestHead.Gaze);
	}
}
