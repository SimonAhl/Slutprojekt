using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float horizontal;
    float vertical;

    //hastigheten spelaren ska ha
    public float speed = 50;

    //spelarens rigidbody
    public Rigidbody2D playerrb;

    void Update()
    {
        //sätter floatsen lika med Unitys inbyggda movementknappar (wasd och pilarna)
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //om man håller in båda sammtidigt ska hastigheten inte bli sammanlagt mer än om man skulle endast hålla in en av dom
        //på grund av detta delar jag hastigheten med roten ur 2 (diagonalen i en kvadrat)
        if(vertical != 0 && horizontal != 0){
            playerrb.velocity = new Vector2(horizontal * speed / Mathf.Sqrt(2), vertical * speed / Mathf.Sqrt(2));
        }else
            // spelaren rör på sig med en hastighet av inputen gånger speed variablen
            playerrb.velocity = new Vector2(horizontal * speed, vertical * speed);
        
    }
}
