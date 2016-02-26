using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameState state = GameObject.FindObjectOfType<GameState>();
        Text text = GetComponent<Text>();
        text.text = "High Score: " + state.highScore + " meters.";
    }
}
