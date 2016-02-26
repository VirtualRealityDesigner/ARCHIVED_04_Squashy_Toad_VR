using UnityEngine;
using System.Collections;

public class GameOverMessage : MonoBehaviour {

    public float UIDistance = 5.0f;
    public float UIHeight = 1.0f;

    private Player player;
    private Canvas canvas;
    private LevelState state;

	// Use this for initialization
	void Start () {
        player = GameObject.FindObjectOfType<Player>();
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        state = GameObject.FindObjectOfType<LevelState>();
	}
	
	// Update is called once per frame
	void Update () {
        if (state.IsGameOver) {
            TrackPlayerHead();
            canvas.enabled = true;
        }
    }

    void TrackPlayerHead()
    {
        transform.rotation = Quaternion.LookRotation(player.LookDirection());
        transform.position = player.transform.position;
        transform.position += player.LookDirection() * UIDistance;
        transform.position += Vector3.up * UIHeight;
    }
}
