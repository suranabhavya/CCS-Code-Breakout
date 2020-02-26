using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerfiy24 : MonoBehaviour
{
    public void WrongOption22()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion26Scene();
    }
    public void RightOption22()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion26Scene();
    }
}
