using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UpdateMyScore : MonoBehaviour
{
    private float myTime = 0.0f;
    private float myInterpolationPeriod = 3.0f;
    void Update()
    {
        myTime += Time.deltaTime;

        if (myTime >= myInterpolationPeriod)
        {
            myTime = 0.0f;
            string path = "C:\\Users\\bhavy\\CCS Code Breakout\\Assets\\score.dat";
            File.WriteAllText(path, FindObjectOfType<SubmitUsername>().username + " :: " + FindObjectOfType<GameStatus>().currentScore.ToString());
        }
    }
}
