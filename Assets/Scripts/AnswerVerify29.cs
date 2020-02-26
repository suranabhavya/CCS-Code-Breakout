using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify29 : MonoBehaviour
{
    public void WrongOption27()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion31Scene();
    }
    public void RightOption27()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion31Scene();
    }
}
