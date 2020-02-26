using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify15 : MonoBehaviour
{
    public void WrongOption13()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion17Scene();
    }
    public void RightOption13()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion17Scene();
    }
}
