using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify1 : MonoBehaviour
{
    public void WrongOption1()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion3Scene();
    }
    public void RightOption1()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion3Scene();
    }
}
