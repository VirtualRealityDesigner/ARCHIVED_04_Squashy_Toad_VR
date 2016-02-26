using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour {

    public float loadLevelAfterTime = 0;

    // Use this for initialization
    void Start() {
        if (loadLevelAfterTime > 0)
        {
            Invoke("LoadNextLevel", loadLevelAfterTime);
        }
	}

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
