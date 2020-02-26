using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify : MonoBehaviour
{
    public void WrongOption()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion2Scene();
    }
    public void RightOption()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion2Scene();
    }
}
