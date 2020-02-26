using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify14 : MonoBehaviour
{
    public void WrongOption12()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion16Scene();
    }
    public void RightOption12()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion16Scene();
    }
}
