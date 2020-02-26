using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify41 : MonoBehaviour
{
    public void WrongOption39()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion43Scene();
    }
    public void RightOption39()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion43Scene();
    }
}
