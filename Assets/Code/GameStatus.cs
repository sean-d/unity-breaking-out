using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(.1f,10f)] [SerializeField] float gameSpeed = 1.0f;
    [SerializeField] int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;


    private void Awake() 
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            Destroy(gameObject);
        }    
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start() 
    {
        scoreText.text = currentScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void IncreaseScore()
    {
        currentScore++;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = currentScore.ToString();
    }
}