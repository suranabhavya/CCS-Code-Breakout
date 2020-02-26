using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify42 : MonoBehaviour
{
    public void WrongOption40()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion44Scene();
    }
    public void RightOption40()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion44Scene();
    }
}
