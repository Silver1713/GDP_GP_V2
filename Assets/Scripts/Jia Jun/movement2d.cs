using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2d : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.AddForce(Vector2.down * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.AddForce(Vector2.up * speed);
        }
    }
}
