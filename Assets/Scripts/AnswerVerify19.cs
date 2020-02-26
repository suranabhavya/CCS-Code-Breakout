using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify19 : MonoBehaviour
{
    public void WrongOption17()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion21Scene();
    }
    public void RightOption17()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion21Scene();
    }
}
