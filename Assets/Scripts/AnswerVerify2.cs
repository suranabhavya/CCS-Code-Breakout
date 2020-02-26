using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify2 : MonoBehaviour
{
    public void WrongOption2()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion4Scene();
    }
    public void RightOption2()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion4Scene();
    }
}
