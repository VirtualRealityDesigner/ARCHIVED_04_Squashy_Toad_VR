using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

    public float jumpAngleInDegree;
    public float jumpSpeed;

    private CardboardHead head;
    private Rigidbody rb;
    private int collisionCount;
    private CapsuleCollider collider;
    private float lastJumpRequestTime = 0.0f;

	// Use this for initialization
	void Start () {
        Cardboard.SDK.OnTrigger += PullTrigger;
        head = GameObject.FindObjectOfType<CardboardHead>();
        rb = GetComponent<Rigidbody>();
	}

    private void PullTrigger()
    {
        RequestJump();
    }

    private void RequestJump()
    {
        lastJumpRequestTime = Time.time;
        rb.WakeUp();
        print("Jump requested at " + lastJumpRequestTime);
    }

    private void Jump()
    {
        print("Jumping");
        float jumpAngleInRadians = jumpAngleInDegree * Mathf.Deg2Rad;
        Vector3 projectedVector = Vector3.ProjectOnPlane(head.Gaze.direction, Vector3.up);
        Vector3 jumpVector = Vector3.RotateTowards(projectedVector, Vector3.up, jumpAngleInRadians, 0);
        rb.velocity = jumpVector * jumpSpeed;
    }

    public void OnCollisionStay(Collision collision)
    {
        float now = Time.time;
        float delta = now - lastJumpRequestTime;
        print("Collision stay at " + now + " with delta " + delta);
        if (delta < 0.1)
        {
            Jump();
            lastJumpRequestTime = 0;
        }
    }

    // Update is called once per frame
    void Update () {
	}
}
