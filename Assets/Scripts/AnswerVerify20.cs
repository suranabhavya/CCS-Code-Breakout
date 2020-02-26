using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerVerify20 : MonoBehaviour
{
    public void WrongOption18()
    {
        FindObjectOfType<GameStatus>().DeductQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion22Scene();
    }
    public void RightOption18()
    {
        FindObjectOfType<GameStatus>().AddQuestionScore();
        FindObjectOfType<LoadScene>().continueAfterQuestion22Scene();
    }
}
