using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify43 : MonoBehaviour
{
    public void WrongOption41()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion45Scene();
    }
    public void RightOption41()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion45Scene();
    }
}
