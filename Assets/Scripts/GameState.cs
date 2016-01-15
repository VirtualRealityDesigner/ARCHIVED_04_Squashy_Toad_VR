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

}
