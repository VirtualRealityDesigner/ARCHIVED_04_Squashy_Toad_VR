using UnityEngine;
using System.Collections;

public class GameOverMessage : MonoBehaviour {

    public float UIDistance = 3.0f;
    public float UIHight = 1.0f;
    private Player player;
    private Canvas canvas;
    private GameState state;

	// Use this for initialization
	void Start () {
        player = GameObject.FindObjectOfType<Player>();
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        state = GameObject.FindObjectOfType<GameState>();
	}
	
	// Update is called once per frame
	void Update () {
        if (state.IsGameOver)
        {
            canvas.enabled = true;
            transform.rotation = Quaternion.LookRotation(player.LookingDirection());
            transform.position = player.transform.position;
            transform.position += player.LookingDirection() * UIDistance;
            transform.position += Vector3.up * UIHight;
        }
	}
}
