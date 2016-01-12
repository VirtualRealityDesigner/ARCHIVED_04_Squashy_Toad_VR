using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

    public float progressionSpeed = 0.01f;//m/s

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        FollowPlayer();
        CreepForward();
	}
    
    void FollowPlayer ()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 delta = player.transform.position - transform.position;
        Vector3 projectedDelta = Vector3.Project(delta, Vector3.left);
        transform.position += projectedDelta;
    }

    void CreepForward()
    {
        transform.position += progressionSpeed * Vector3.forward;
    }
}
