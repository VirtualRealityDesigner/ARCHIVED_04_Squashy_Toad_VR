using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GazeTest : MonoBehaviour {

    public Text gazeText;

	// Use this for initialization
	void Start () {
        //Cardboard.SDK.OnTrigger += PullTrigger;
	}

    private void PullTrigger()
    {
        gazeText.enabled = !gazeText.enabled;
    }

    // Update is called once per frame
    void Update () {
        var mouseX = Input.GetAxis("Mouse X");
        if (mouseX > 1.0f)
        {
            gazeText.text = "Swipe Detected";
        }
    }
}
