using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private CardboardHead mainHead;

	// Use this for initialization
	void Start () {
        Cardboard.SDK.OnTrigger += Jump;
        mainHead = GameObject.FindObjectOfType<CardboardHead>();
    }

    // Update is called once per frame
    void Update () {
	}

    private void Jump()
    {
        gameObject.transform.Translate(mainHead.Gaze.direction);
    }
}
