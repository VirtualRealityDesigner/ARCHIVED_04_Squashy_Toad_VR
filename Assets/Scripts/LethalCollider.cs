using UnityEngine;
using System.Collections;

public class LethalCollider : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            LevelState state = GameObject.FindObjectOfType<LevelState>();
            state.IsGameOver = true;
        }
    }
}
