using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify16 : MonoBehaviour
{
    public void WrongOption14()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion18Scene();
    }
    public void RightOption14()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion18Scene();
    }
}
