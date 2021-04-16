using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    [Range(.1f,10f)] [SerializeField] float gameSpeed = 1.0f;

    [SerializeField] bool isAutoPlayEnabled = false;

    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }



}
