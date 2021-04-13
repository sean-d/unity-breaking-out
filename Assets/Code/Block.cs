using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Create state for level so we can call it outside of Start()
    LevelMgmt level;
    GameStatus game;
    // Start is called before the first frame update
    private void Start() {
        level = FindObjectOfType<LevelMgmt>();
        level.StartingNumberBreakableBlocks();
        game = FindObjectOfType<GameStatus>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        DestroyBlock();
        IncreaseScore();
    }

    private void DestroyBlock()
    {
        Destroy(gameObject);
        level.CountBrokenBlock();
    }

    private void IncreaseScore()
    {
        game.IncreaseScore();
    }
}
