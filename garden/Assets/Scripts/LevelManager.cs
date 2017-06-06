using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float autoloadNextLevelAfter = 0f;

    void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest() {
        Application.Quit();
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(sceneBuildIndex);
    }
}