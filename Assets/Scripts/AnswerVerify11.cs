using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify11 : MonoBehaviour
{
    public void WrongOption9()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion13Scene();
    }
    public void RightOption9()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion13Scene();
    }
}
