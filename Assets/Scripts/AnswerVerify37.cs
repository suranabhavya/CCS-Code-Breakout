using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify37 : MonoBehaviour
{
    public void WrongOption35()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion39Scene();
    }
    public void RightOption35()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion39Scene();
    }
}
