using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q17Generator : MonoBehaviour
{
    QuestionLevel questionLevel;
    // Start is called before the first frame update
    public void Start()
    {
        questionLevel = FindObjectOfType<QuestionLevel>();
        questionLevel.CountQuestionableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        questionLevel.QuestionableBlockDestroyed16();
    }
}
