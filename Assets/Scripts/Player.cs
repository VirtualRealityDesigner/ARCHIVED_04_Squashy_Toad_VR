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
    private GameState state;

	// Use this for initialization
	void Start () {
        Cardboard.SDK.OnTrigger += PullTrigger;
        head = GameObject.FindObjectOfType<CardboardHead>();
        rb = GetComponent<Rigidbody>();
        state = FindObjectOfType<GameState>();
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
        Vector3 jumpVector = Vector3.RotateTowards(LookingDirection(), Vector3.up, jumpAngleInRadians, 0);
        rb.velocity = jumpVector * jumpSpeed;
    }

    public Vector3 LookingDirection()
    {
        return Vector3.ProjectOnPlane(head.Gaze.direction, Vector3.up);
    }

    void OnCollisionStay(Collision collision)
    {
        float delta = Time.time - lastJumpRequestTime;
        if (delta < 0.1 && !state.IsGameOver)
        {
            Jump();
            lastJumpRequestTime = 0.0f;
        }
    }

    // Update is called once per frame
    void Update () {
	}
}
