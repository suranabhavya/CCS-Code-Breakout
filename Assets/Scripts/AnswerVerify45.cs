using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify45 : MonoBehaviour
{
    public void WrongOption43()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion47Scene();
    }
    public void RightOption43()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion47Scene();
    }
}
