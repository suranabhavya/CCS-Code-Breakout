using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify36 : MonoBehaviour
{
    public void WrongOption34()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion38Scene();
    }
    public void RightOption34()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion38Scene();
    }
}
