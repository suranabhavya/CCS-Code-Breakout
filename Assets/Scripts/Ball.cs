using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    Vector2 paddleToBallVector;
    public bool hasStarted = false;
    public bool onDoubleClick = false;
    [SerializeField] float xPush = 4f;
    [SerializeField] float yPush = 15f;
    [SerializeField] float randomFactor = 0.2f;
    Rigidbody2D myRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted == false)
        {
            if (onDoubleClick == false)
            {
                LockBallToPaddle();
                LaunchOnMouseClick();
            }
            else
            {
                LockBallToPaddle();
                LaunchOnDoubleMouseClick();
            }
        }
    }
    public void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2(Random.Range(0f, randomFactor), Random.Range(0f, randomFactor));
        if (hasStarted)
        {
            myRigidbody2D.velocity += velocityTweak;
        }
    }
    private void LaunchOnMouseClick()
    {
        if(Input.GetKeyDown("space"))
        {
            hasStarted = true;
            myRigidbody2D.velocity = new Vector2(xPush, yPush);
        }
    }
    private void LaunchOnDoubleMouseClick()
    {
        if (Input.GetKeyDown("space"))
        {
            hasStarted = true;
            myRigidbody2D.velocity = new Vector2(xPush, yPush);
        }
    }
}
