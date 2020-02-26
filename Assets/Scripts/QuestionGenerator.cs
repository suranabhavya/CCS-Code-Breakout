using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    QuestionLevel questionLevel;
    private void Start()
    {
        questionLevel = FindObjectOfType<QuestionLevel>();
        questionLevel.CountQuestionableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        questionLevel.QuestionableBlockDestroyed();
    }
}
