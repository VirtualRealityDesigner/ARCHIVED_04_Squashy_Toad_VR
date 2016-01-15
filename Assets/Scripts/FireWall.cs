using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

    public float creepSpeed = 0.01f;

    private GameState state;

    void Start ()
    {
        state = FindObjectOfType<GameState>();
    }

    // Update is called once per frame
    void Update () {
        if (!state.IsGameOver)
        {
            FollowPlayer();
            CreepForward();
            HasCaughtUpWithPlayer();
        }
    }

    void FollowPlayer ()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 delta = player.transform.position - transform.position;
        Vector3 projectedDelta = Vector3.Project(delta, Vector3.left);
        transform.position += projectedDelta;
    }

    void CreepForward ()
    {
        transform.position += Vector3.forward * creepSpeed;
    }

    void HasCaughtUpWithPlayer ()
    {
        GameObject player = GameObject.Find("Player");
        if (player.transform.position.z < transform.position.z)
        {
            state.SetGameOver();
        }
    }
}
