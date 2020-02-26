using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify10 : MonoBehaviour
{
    public void WrongOption8()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion12Scene();
    }
    public void RightOption8()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion12Scene();
    }
}
