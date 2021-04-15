using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    GameStatus game;

    public void LoadNextScene()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (CurrentSceneIndex > SceneManager.sceneCount)
        {
            LoadStartScene();
        }
        else
        {
            SceneManager.LoadScene(CurrentSceneIndex + 1);            
        }
    }

    public void LoadStartScene()
    {
        FindObjectOfType<GameStatus>().ResetGameStatus();
        SceneManager.LoadScene(0);
    }
}
