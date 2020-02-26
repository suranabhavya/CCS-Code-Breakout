using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify31 : MonoBehaviour
{
    public void WrongOption29()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion33Scene();
    }
    public void RightOption29()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion33Scene();
    }
}
