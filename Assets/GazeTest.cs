using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GazeTest : MonoBehaviour {

    public Text gazeText;

    private CardboardHead gazeTestHead;
    private Rigidbody rb; 

	// Use this for initialization
	void Start () {
        Cardboard.SDK.OnTrigger += PullTrigger;
        gazeTestHead = GameObject.FindObjectOfType<CardboardHead>();
        rb = GetComponent<Rigidbody>();
	}

    private void PullTrigger()
    {
        rb.AddForce(gazeTestHead.Gaze.direction * 1000);
    }

    // Update is called once per frame
    void Update () {
	    gazeText.text = gazeTestHead.Gaze.ToString();
	}
}
