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
        var camera = GetComponent<Camera>();
        var lookDirection = camera.transform.rotation * Vector3.forward;
	    gazeText.text = lookDirection.ToString();
	}
}
