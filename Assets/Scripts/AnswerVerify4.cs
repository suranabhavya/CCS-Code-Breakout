using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify4 : MonoBehaviour
{
    public void WrongOption4()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion6Scene();
    }
    public void RightOption4()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion6Scene();
    }
}
