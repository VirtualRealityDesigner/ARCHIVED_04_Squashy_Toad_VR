using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ToadMove : MonoBehaviour {

    public float speed = 5f;
    private Transform vrCam;

	// Use this for initialization
	void Start () {
        vrCam = GetComponentInChildren<Camera>().transform;
	}

    // Update is called once per frame
    void Update() {
        float forwardSpeed = CrossPlatformInputManager.GetAxis("Vertical");
        transform.Translate (vrCam.forward * forwardSpeed * speed * Time.deltaTime);
    }
}
