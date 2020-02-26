using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonScript : MonoBehaviour
{
    Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
    }
    public void OnResetButtonClick()
    {
        ball.hasStarted = false;
        FindObjectOfType<GameStatus>().DeductLosingBall();
    }
}
