using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify7 : MonoBehaviour
{
    public void WrongOption7()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion9Scene();
    }
    public void RightOption7()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion9Scene();
    }
}
