using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GazeTest : MonoBehaviour {

    public Text debugText;

    private CardboardHead cardboardHead;

    // Use this for initialization
    void Start () {
        // print ("Looking for head...");
        cardboardHead = GameObject.FindObjectOfType<CardboardHead>();
        print (cardboardHead);
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.Log(cardboardHead.Gaze);
        debugText.text = cardboardHead.Gaze.ToString();
    }
}
