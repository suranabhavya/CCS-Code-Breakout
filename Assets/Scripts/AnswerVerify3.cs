using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify3 : MonoBehaviour
{
    public void WrongOption3()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion5Scene();
    }
    public void RightOption3()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion5Scene();
    }
}
