using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify33 : MonoBehaviour
{
    public void WrongOption31()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion35Scene();
    }
    public void RightOption31()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion35Scene();
    }
}
