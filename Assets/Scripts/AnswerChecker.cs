using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    public void GetInput1(string ans1)
    {
        if(ans1 == "1")
        {
            FindObjectOfType<GameStatus>().AddQuestionScore();
            FindObjectOfType<LoadScene>().continueAfterQuestion2Scene();
        }
        else
        {
            FindObjectOfType<GameStatus>().DeductQuestionScore();
            FindObjectOfType<LoadScene>().continueAfterQuestion2Scene();
        }
    }
}
