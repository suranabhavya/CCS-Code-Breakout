using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify18 : MonoBehaviour
{
    public void WrongOption16()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion20Scene();
    }
    public void RightOption16()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion20Scene();
    }
}
