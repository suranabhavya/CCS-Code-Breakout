using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify13 : MonoBehaviour
{
    public void WrongOption11()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion15Scene();
    }
    public void RightOption11()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion15Scene();
    }
}
