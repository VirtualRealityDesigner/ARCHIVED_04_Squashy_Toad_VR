using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

    public float creepSpeed = 0.01f;

    private Player player;
    private GameState state;

	// Use this for initialization
	void Start () {
        player = GameObject.FindObjectOfType<Player>();
        state = GameObject.FindObjectOfType<GameState>();
	}
	
	// Update is called once per frame
	void Update () {
        FollowPlayer();
        CreepForward();
        CheckPlayerBurnt();
	}

    void FollowPlayer ()
    {
        Vector3 delta = player.transform.position - transform.position;
        Vector3 projectedDelta = Vector3.Project(delta, Vector3.left);
        transform.position += projectedDelta;
    }

    void CreepForward ()
    {
        transform.position += Vector3.forward * creepSpeed;
    }

    void CheckPlayerBurnt()
    {
        if (player.transform.position.z < transform.position.z)
        {
            state.IsGameOver = true;
        }
    }
}
