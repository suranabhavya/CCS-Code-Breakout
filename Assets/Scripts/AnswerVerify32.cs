using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify32 : MonoBehaviour
{
    public void WrongOption30()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion34Scene();
    }
    public void RightOption30()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion34Scene();
    }
}
