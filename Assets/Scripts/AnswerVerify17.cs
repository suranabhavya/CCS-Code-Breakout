using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify17 : MonoBehaviour
{
    public void WrongOption15()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion19Scene();
    }
    public void RightOption15()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion19Scene();
    }
}
