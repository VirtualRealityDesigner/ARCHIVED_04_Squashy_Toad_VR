using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

    public float jumpAngleInDegree;
    public float jumpSpeed;

    private CardboardHead head;
    private Rigidbody rb;
    private int collisionCount;

	// Use this for initialization
	void Start () {
        Cardboard.SDK.OnTrigger += PullTrigger;
        head = GameObject.FindObjectOfType<CardboardHead>();
        rb = GetComponent<Rigidbody>();
	}

    private void PullTrigger()
    {
        print("PullTrigger");
        if (collisionCount > 0)
        {
            float jumpAngleInRadians = jumpAngleInDegree * Mathf.Deg2Rad;
            Vector3 projectedVector = Vector3.ProjectOnPlane(head.Gaze.direction, Vector3.up);
            Vector3 jumpVector = Vector3.RotateTowards(projectedVector, Vector3.up, jumpAngleInRadians, 0);
            rb.velocity = jumpVector * jumpSpeed;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        print("OnCollisionEnter" + collision.collider.GetHashCode());
        collisionCount++;
        print(collisionCount);
    }

    void OnCollisionExit(Collision collision)
    {
        print("OnCollisionExit" + collision.collider.GetHashCode());
        collisionCount--;
        print(collisionCount);
    }

    // Update is called once per frame
    void Update () {
	}
}
