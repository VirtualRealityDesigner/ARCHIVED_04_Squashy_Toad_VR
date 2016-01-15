using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {


    private bool isGameOver = false;

    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
    }

    public void SetGameOver()
    {
        isGameOver = true;
    }

    public void ResetGame()
    {
        Application.LoadLevel("Main");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("SplashScreen");
    }
}
