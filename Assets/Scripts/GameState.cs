using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public void ResetGame()
    {
        Application.LoadLevel("Main");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("SplashScreen");
    }
}
