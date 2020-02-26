using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify40 : MonoBehaviour
{
    public void WrongOption38()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion42Scene();
    }
    public void RightOption38()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion42Scene();
    }
}
