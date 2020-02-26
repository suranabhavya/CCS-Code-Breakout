using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify39 : MonoBehaviour
{
    public void WrongOption37()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion41Scene();
    }
    public void RightOption37()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion41Scene();
    }
}
