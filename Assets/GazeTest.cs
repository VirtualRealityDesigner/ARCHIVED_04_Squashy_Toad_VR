using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GazeTest : MonoBehaviour {

    public Text gazeText;

    private CardboardHead mainCardboardHead;

	// Use this for initialization
	void Start () {
        mainCardboardHead = GameObject.FindObjectOfType<CardboardHead>();
	}
	
	// Update is called once per frame
	void Update () {
        gazeText.text = mainCardboardHead.Gaze.ToString();
	}
}
