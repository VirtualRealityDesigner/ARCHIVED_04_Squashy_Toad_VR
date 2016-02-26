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
        LoadLevelByOffset(1);
    }

    public void LoadLevelByOffset(int indexOffset)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + indexOffset);
    }
}
