using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController1 : MonoBehaviour
{
    public void GetInput(string ans)
    {
        if (ans == "c")
        {
            FindObjectOfType<GameStatus>().AddQuestionScore();
            FindObjectOfType<LoadScene>().continueAfterQuestion1Scene();
        }
        else
        {
            FindObjectOfType<GameStatus>().DeductQuestionScore();
            FindObjectOfType<LoadScene>().continueAfterQuestion1Scene();
        }
    }
}