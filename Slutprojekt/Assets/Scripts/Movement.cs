using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public Animator animator;
    float horizontal;
    float vertical;

    //Hastigheten spelaren ska ha
    public float speed = 50;

    //Spelarens rigidbody
    public Rigidbody2D playerrb;

    void Update()
    {
        //Sätter floatsen lika med Unitys inbyggda movementknappar (wasd och pilarna)
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //Om spelaren rör på sig ska animationsvariabeln "IsMoving" vara true, annars false
        //Det är detta som är kärnan i walking animationen
        //Om spelaren rör på sig så spelas animationen annars går den tillbaka till base spriten
        if(horizontal != 0 || vertical != 0){
            animator.SetBool("IsMoving", true);
        }else
            animator.SetBool("IsMoving", false);
    }

    private void FixedUpdate()
    {
        //Om man håller in båda sammtidigt ska hastigheten inte bli sammanlagt mer än om man skulle endast hålla in en av dom
        //På grund av detta delar jag hastigheten med roten ur 2 (diagonalen i en kvadrat)
        if(vertical != 0 && horizontal != 0){
            playerrb.velocity = new Vector2(horizontal * speed / Mathf.Sqrt(2), vertical * speed / Mathf.Sqrt(2));
        }else
            //Spelaren rör på sig med en hastighet av inputen gånger speed variablen
            playerrb.velocity = new Vector2(horizontal * speed, vertical * speed);
        
    }
}
