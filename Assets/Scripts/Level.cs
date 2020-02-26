using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    LoadScene loadscene;
    [SerializeField] public int breakableBlocks;
    [SerializeField] public int shakingBlocks;
    public void Start()
    {
        loadscene = FindObjectOfType<LoadScene>();
    }
    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
    public void CountShakingBlocks()
    {
        shakingBlocks++;
    }
    public void ShakingBlockDestroyed()
    {
        shakingBlocks--;
        if (breakableBlocks <= 0 && shakingBlocks <= 0)
        {
            loadscene.loadNextScene();
        }
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        
        if (breakableBlocks <= 0 && shakingBlocks <=0)
        {
            loadscene.loadNextScene();
        }
    }
}
