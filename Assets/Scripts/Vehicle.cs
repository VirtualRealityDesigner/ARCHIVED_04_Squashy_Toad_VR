using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

    private float speed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}

    public void SetSpeed(float someSpeed)
    {
        speed = someSpeed;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
