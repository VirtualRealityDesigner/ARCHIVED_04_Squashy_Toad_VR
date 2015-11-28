using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Text myText;

	// Use this for initialization
	void Start () {
        Cardboard.SDK.OnTrigger += PullTrigger;
	}

    private void PullTrigger()
    {
        myText.enabled = !myText.enabled;
    }

    // Update is called once per frame
    void Update () {
	}
}
