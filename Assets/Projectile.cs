using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        Destroy(gameObject);
    }
}
