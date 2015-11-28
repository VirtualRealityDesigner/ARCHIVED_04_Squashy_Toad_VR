using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GazeTest : MonoBehaviour {

    public Text gazeText;

    private CardboardHead gazeTestHead;

	// Use this for initialization
	void Start () {
        gazeTestHead = GameObject.FindObjectOfType<CardboardHead>();
	}
	
	// Update is called once per frame
	void Update () {
	    gazeText.text = gazeTestHead.Gaze.ToString();
	}
}
