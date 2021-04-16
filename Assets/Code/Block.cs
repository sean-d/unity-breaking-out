using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Create state for level so we can call it outside of Start()
    LevelMgmt level;
    GameStatus game;
    int timesHit = 0;
    [SerializeField] Sprite[] hitSprites;
    // Start is called before the first frame update
    private void Start()
    {

        level = FindObjectOfType<LevelMgmt>();
        game = FindObjectOfType<GameStatus>();
        CountBreakableBlocks();
    }

    private void CountBreakableBlocks()
    {
        if (tag == "Breakable")
        {
            level.StartingNumberOfBlocks();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (tag == "Breakable")
        {
            int maxHits = hitSprites.Length;
            timesHit++;
            if (timesHit == maxHits)
            {
                DestroyBlock();
            }
            else 
            {
                ShowSpriteDamage();
            }

  
        } 

    }

    private void ShowSpriteDamage()
    {
        int spriteIndex = timesHit;
        GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }

    private void DestroyBlock()
    {

        Destroy(gameObject);
        level.CountBrokenBlock();
    }

}
