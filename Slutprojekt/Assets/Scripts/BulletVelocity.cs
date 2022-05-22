using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVelocity : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;
    void Start()
    {
        //Gör objektets hastighet lika med dess riktning gånger negativa farten, anledningen att den är negativ är för att tekniskt sätt är objektet spawnat baklänges
        rb.velocity = transform.up * -speed;
    }
}
