using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q11Generator : MonoBehaviour
{
    QuestionLevel questionLevel;
    // Start is called before the first frame update
    void Start()
    {
        questionLevel = FindObjectOfType<QuestionLevel>();
        questionLevel.CountQuestionableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        questionLevel.QuestionableBlockDestroyed10();
    }
}
