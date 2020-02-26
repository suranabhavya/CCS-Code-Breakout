using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify27 : MonoBehaviour
{
    public void WrongOption25()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion29Scene();
    }
    public void RightOption25()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion29Scene();
    }
}
