using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMgmt : MonoBehaviour
{
    // debug is why this is here
    [SerializeField] int breakableBlocks;
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    public void StartingNumberOfBlocks()
    {
            breakableBlocks++;
    }

    public void CountBrokenBlock()
    {
        breakableBlocks--;

        if(breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }

}
