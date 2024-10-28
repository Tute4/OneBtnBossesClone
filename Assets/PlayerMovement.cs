using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float radius = 2f;

    private Vector3 centerPosition;

    void Start()
    {
        centerPosition = transform.position; 
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        
        float angle = Time.time * speed;
        float x = centerPosition.x + Mathf.Cos(angle) * radius;
        float y = centerPosition.y + Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, y, 0);

        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            radius -= 0.5f;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            radius += 0.5f;
        }
    }
}
