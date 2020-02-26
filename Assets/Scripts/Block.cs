using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Transform boomObj;
    public Transform powerUpSize;
    public Transform powerDownSize;
    public Transform ballSpeedSlow;
    public Transform ballSpeedFast;
    public Transform increaseScore;
    public int whichPowerUp;
    Level level;
    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }
    private void DestroyBlock()
    {
        FindObjectOfType<GameStatus>().AddToScore();
        whichPowerUp = Random.Range(1, 20);
        if (whichPowerUp == 5)
        {
            Instantiate(powerUpSize, transform.position, powerUpSize.rotation);
        }
        if (whichPowerUp == 8)
        {
            Instantiate(powerDownSize, transform.position, powerDownSize.rotation);
        }
        if (whichPowerUp == 1)
        {
            Instantiate(ballSpeedSlow, transform.position, ballSpeedSlow.rotation);
        }
        if (whichPowerUp == 7)
        {
            Instantiate(ballSpeedFast, transform.position, ballSpeedFast.rotation);
        }
        if (whichPowerUp == 13)
        {
            Instantiate(increaseScore, transform.position, increaseScore.rotation);
        }
        Destroy(gameObject);
        Instantiate(boomObj, transform.position, boomObj.rotation);
        level.BlockDestroyed();
    }
}
