using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;
    private float BoostTime = 0f;
    private int counter = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "PowerUpSize(Clone)")
        {
            Destroy(GameObject.FindWithTag("PowerUp"));
            FindObjectOfType<GameStatus>().gameSpeed = 0.7f;
            GetComponent<Transform>().localScale = new Vector2(2, 1.5f);
        }
        if (other.gameObject.name == "PowerDownSize(Clone)")
        {
            Destroy(GameObject.FindWithTag("PowerDown"));
            FindObjectOfType<GameStatus>().gameSpeed = 0.7f;
            GetComponent<Transform>().localScale = new Vector2(0.75f, 1f);
        }
        if (other.gameObject.name == "BallSpeedSlow(Clone)")
        {
            Destroy(GameObject.FindWithTag("BallSlow"));
            GetComponent<Transform>().localScale = new Vector2(1.367973f, 1.028502f);
            FindObjectOfType<GameStatus>().gameSpeed = 0.45f;
        }
        if (other.gameObject.name == "BallSpeedFast(Clone)")
        {
            Destroy(GameObject.FindWithTag("BallFast"));
            GetComponent<Transform>().localScale = new Vector2(1.367973f, 1.028502f);
            FindObjectOfType<GameStatus>().gameSpeed = 0.9f;
        }
        if (other.gameObject.name == "IncreaseScore(Clone)")
        {
            Destroy(GameObject.FindWithTag("ScoreIncrease"));
            GetComponent<Transform>().localScale = new Vector2(1.367973f, 1.028502f);
            FindObjectOfType<GameStatus>().gameSpeed = 0.7f;
            FindObjectOfType<GameStatus>().AddPowerUpScore();
        }
    }
}
