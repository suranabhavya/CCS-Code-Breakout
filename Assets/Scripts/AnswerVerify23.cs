using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify23 : MonoBehaviour
{
    public void WrongOption21()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion25Scene();
    }
    public void RightOption21()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion25Scene();
    }
}
