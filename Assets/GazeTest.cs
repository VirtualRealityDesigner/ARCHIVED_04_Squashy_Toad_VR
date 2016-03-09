using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GazeTest : MonoBehaviour {

    public Text gazeText;

    //private CardboardHead gazeTestHead;

	// Use this for initialization
	void Start () {
        //Cardboard.SDK.OnTrigger += PullTrigger;
        //gazeTestHead = GameObject.FindObjectOfType<CardboardHead>();
	}

    private void PullTrigger()
    {
        gazeText.enabled = !gazeText.enabled;
    }

    // Update is called once per frame
    void Update () {
	    //gazeText.text = gazeTestHead.Gaze.ToString();
	}
}
