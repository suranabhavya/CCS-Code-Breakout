using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify22 : MonoBehaviour
{
    public void WrongOption20()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion24Scene();
    }
    public void RightOption20()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion24Scene();
    }
}
