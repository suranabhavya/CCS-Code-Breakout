using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify46 : MonoBehaviour
{
    public void WrongOption44()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion48Scene();
    }
    public void RightOption44()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion48Scene();
    }
}
