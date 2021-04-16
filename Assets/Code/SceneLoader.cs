using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
    {

        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;

         if (CurrentSceneIndex > SceneManager.sceneCountInBuildSettings)
         {
             LoadStartScene();
         }
         else
         {
            SceneManager.LoadScene(CurrentSceneIndex + 1);           
        }
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadStartScene()
    {
        FindObjectOfType<GameStatus>().ResetGameStatus();
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
