using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake (float duration, float magnitude)
    {
        
        float elapsed = 0.0f;
        Vector3 originalPos = transform.localPosition;
        
        while (elapsed < duration)
        {
            Debug.Log("Shaking");
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.localPosition = new Vector3(x + originalPos.x, y + originalPos.y, originalPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = new Vector3(8.0f, 6.0f, -10.0f);
    }
}
