using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class SubmitUsername : MonoBehaviour
{
    public InputField inputText;
    public string username;
    // Start is called before the first frame update
    void Start()
    {
        username = PlayerPrefs.GetString("Username");
        inputText.text = username;
    }
    public void submitThis()
    {
        username = inputText.text;
        PlayerPrefs.SetString("Username", username);
        print(username);
        StartSendingScore();
    }
    public void StartSendingScore()
    {
        Invoke("ScoreSend", 5f);
        SceneManager.LoadScene(1);
        Debug.Log("loaded scene");
    }
    public void ScoreSend()
    {
        string path = Application.dataPath;
        File.WriteAllText(path.ToString() + "/score.dat", FindObjectOfType<GameStatus>().currentScore.ToString());
    }
}
