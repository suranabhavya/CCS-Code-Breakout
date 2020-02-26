using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify21 : MonoBehaviour
{
    public void WrongOption19()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion23Scene();
    }
    public void RightOption19()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion23Scene();
    }
}
