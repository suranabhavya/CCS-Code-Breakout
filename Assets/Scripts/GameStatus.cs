using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [SerializeField] public int currentScore = 0;
    [SerializeField] int pointsPerBlockDestroyed = 50;
    [SerializeField] int pointsPerCorrectAnswer = 500;
    [SerializeField] int pointsPerWrongAnswer = 200;
    [SerializeField] int pointsPerLosingBall = 100;
    [Range(0.1f,10f)][SerializeField] public float gameSpeed = 1f;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float mainTimer;
    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    public void Start()
    {
        scoreText.text = currentScore.ToString();
        timer = mainTimer;
    }
    // Update is called once per frame
    void Update()
    {
            Time.timeScale = gameSpeed;
            if (timer >= 0.0f && canCount)
            {
                timer -= Time.deltaTime;
                timerText.text = timer.ToString("F");
            }
            else if (timer <= 0.0f && !doOnce)
            {
                canCount = false;
                doOnce = true;
                timerText.text = "0.00";
                timer = 0.0f;
                FindObjectOfType<LoadScene>().ExitMenu();
            }
    }
    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
    public void AddQuestionScore()
    {
        currentScore += pointsPerCorrectAnswer;
        scoreText.text = currentScore.ToString();
    }
    public void DeductQuestionScore()
    {
        currentScore -= pointsPerWrongAnswer;
        scoreText.text = currentScore.ToString();
    }
    public void DeductLosingBall()
    {
        currentScore -= pointsPerLosingBall;
        scoreText.text = currentScore.ToString();
    }
    public void AddPowerUpScore()
    {
        currentScore += pointsPerLosingBall;
        scoreText.text = currentScore.ToString();
    }
}
