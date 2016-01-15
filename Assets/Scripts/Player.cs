using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

    public float jumpAngleInDegree;
    public float jumpSpeed;

    private CardboardHead head;
    private Rigidbody rb;
    private bool onFloor;
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
    }

    private void Jump()
    {
        float jumpAngleInRadians = jumpAngleInDegree * Mathf.Deg2Rad;
        Vector3 projectedVector = Vector3.ProjectOnPlane(head.Gaze.direction, Vector3.up);
        Vector3 jumpVector = Vector3.RotateTowards(projectedVector, Vector3.up, jumpAngleInRadians, 0);
        rb.velocity = jumpVector * jumpSpeed;
    }

    void OnCollisionStay(Collision collision)
    {
        float delta = Time.time - lastJumpRequestTime;
        if (delta < 0.1)
        {
            Jump();
            lastJumpRequestTime = 0.0f;
        }
    }

    // Update is called once per frame
    void Update () {
	}
}
