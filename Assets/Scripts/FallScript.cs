using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    Rigidbody2D yourRigidbody2D;
    [SerializeField] float DownwardForce = -2f;
    // Start is called before the first frame update
    void Start()
    {
        yourRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        yourRigidbody2D.velocity = new Vector2(0.0f, DownwardForce);
    }
}
