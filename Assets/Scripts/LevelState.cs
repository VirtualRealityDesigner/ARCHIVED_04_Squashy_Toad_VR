using UnityEngine;
using System.Collections;

public class LevelState : MonoBehaviour {

    public bool IsGameOver { get; set; }

	public void ResetGame()
    {
        SceneLoader loader = GameObject.FindObjectOfType<SceneLoader>();
        loader.LoadLevelByOffset(0);
    }

    public void BackToMenu()
    {
        SceneLoader loader = GameObject.FindObjectOfType<SceneLoader>();
        loader.LoadLevelByOffset(-1);
    }
}
