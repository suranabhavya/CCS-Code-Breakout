using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class StartLevel1 : MonoBehaviour
{
    public void StartSendingScore()
    {
        Invoke("ScoreSend", 5f);
        SceneManager.LoadScene(1);
        Debug.Log("loaded scene");
    }
    public void ScoreSend()
    {
        string path = "C:\\Users\\bhavy\\CCS Code Breakout\\Assets\\liveScore.txt";
        File.WriteAllText(path, FindObjectOfType<GameStatus>().currentScore.ToString());
    }
}
