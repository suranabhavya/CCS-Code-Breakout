using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify25 : MonoBehaviour
{
    public void WrongOption23()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion27Scene();
    }
    public void RightOption23()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion27Scene();
    }
}
