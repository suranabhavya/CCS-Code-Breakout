using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify28 : MonoBehaviour
{
    public void WrongOption26()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion30Scene();
    }
    public void RightOption26()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion30Scene();
    }
}
