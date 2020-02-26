using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify9 : MonoBehaviour
{
    public void WrongOption48()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion11Scene();
    }
    public void RightOption48()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion11Scene();
    }
}
