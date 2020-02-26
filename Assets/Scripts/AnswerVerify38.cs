using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify38 : MonoBehaviour
{
    public void WrongOption36()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion40Scene();
    }
    public void RightOption36()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion40Scene();
    }
}
