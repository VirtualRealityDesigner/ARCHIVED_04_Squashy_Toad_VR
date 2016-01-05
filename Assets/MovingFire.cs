using UnityEngine;
using System.Collections;

public class MovingFire : MonoBehaviour {

    public float velocity = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject player = GameObject.Find("Player");
        Vector3 sidewaysVector = Vector3.left;
        Vector3 projectedPlayer = Vector3.Project(player.transform.position, sidewaysVector);
        Vector3 projectedFire = Vector3.Project(transform.position, sidewaysVector);
        transform.position += projectedPlayer - projectedFire;
        transform.position += Vector3.forward * Time.deltaTime * velocity;
	}
}
