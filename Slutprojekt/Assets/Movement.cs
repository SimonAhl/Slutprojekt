using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float horizontal;
    float vertical;
    public float speed = 50;
    public Rigidbody2D playerrb;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        playerrb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
