using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUps : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PowerUpSize(Clone)")
        {
            Destroy(GameObject.FindWithTag("PowerUp"));
        }
        if (collision.gameObject.name == "PowerDownSize(Clone)")
        {
            Destroy(GameObject.FindWithTag("PowerDown"));
        }
        if (collision.gameObject.name == "BallSpeedSlow(Clone)")
        {
            Destroy(GameObject.FindWithTag("BallSlow"));
        }
        if (collision.gameObject.name == "BallSpeedFast(Clone)")
        {
            Destroy(GameObject.FindWithTag("BallFast"));
        }
        if (collision.gameObject.name == "IncreaseScore(Clone)")
        {
            Destroy(GameObject.FindWithTag("ScoreIncrease"));
        }
    }
}
