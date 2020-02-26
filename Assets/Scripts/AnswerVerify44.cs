using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify44 : MonoBehaviour
{
    public void WrongOption42()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion46Scene();
    }
    public void RightOption42()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion46Scene();
    }
}
