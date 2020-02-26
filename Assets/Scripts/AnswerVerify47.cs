using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify47 : MonoBehaviour
{
    public void WrongOption45()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion49Scene();
    }
    public void RightOption45()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion49Scene();
    }
}
