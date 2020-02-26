using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify26 : MonoBehaviour
{
    public void WrongOption24()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion28Scene();
    }
    public void RightOption24()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion28Scene();
    }
}
