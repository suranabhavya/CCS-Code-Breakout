using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShaking : MonoBehaviour
{
    Level level;
    CameraShake cameraShaking;
    public CameraShake cameraShake;
    private void Start()
    {
        level = FindObjectOfType<Level>();
        cameraShaking = FindObjectOfType<CameraShake>();
        level.CountShakingBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyShakeBlock();
        cameraShaking.StartCoroutine(cameraShake.Shake(.8f, .6f));
    }
    public void DestroyShakeBlock()
    {
        FindObjectOfType<GameStatus>().AddToScore();
        Destroy(gameObject);
        level.ShakingBlockDestroyed();
    }
}
