using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify12 : MonoBehaviour
{
    public void WrongOption10()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion14Scene();
    }
    public void RightOption10()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion14Scene();
    }
}
