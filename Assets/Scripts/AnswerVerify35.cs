using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify35 : MonoBehaviour
{
    public void WrongOption33()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion37Scene();
    }
    public void RightOption33()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion37Scene();
    }
}
