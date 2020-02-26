using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify48 : MonoBehaviour
{
    public void WrongOption46()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion50Scene();
    }
    public void RightOption46()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion50Scene();
    }
}
