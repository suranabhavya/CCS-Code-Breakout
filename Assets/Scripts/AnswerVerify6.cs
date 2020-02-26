using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify6 : MonoBehaviour
{
    public void WrongOption6()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion8Scene();
    }
    public void RightOption6()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion8Scene();
    }
}
