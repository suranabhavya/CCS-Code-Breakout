using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify5 : MonoBehaviour
{
    public void WrongOption5()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion7Scene();
    }
    public void RightOption5()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion7Scene();
    }
}
