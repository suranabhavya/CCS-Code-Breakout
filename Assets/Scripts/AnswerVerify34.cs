using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify34 : MonoBehaviour
{
    public void WrongOption32()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion36Scene();
    }
    public void RightOption32()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion36Scene();
    }
}
