using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify30 : MonoBehaviour
{
    public void WrongOption28()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion32Scene();
    }
    public void RightOption28()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion32Scene();
    }
}
