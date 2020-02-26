using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify8 : MonoBehaviour
{
    public void WrongOption47()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion10Scene();
    }
    public void RightOption47()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion10Scene();
    }
}
