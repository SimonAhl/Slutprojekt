using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{

    Transform playerpos;
    public SpriteRenderer spriteR;
    [SerializeField] float speed;
    void Update()
    {
        //Gör playerpos vara lika med transformen av spelaren
        playerpos = GameObject.Find("Player").transform;

        //Sätter objektets rotation till att kolla rakt på spelaren
        transform.LookAt(playerpos);

        //Rör objektet framåt genom att ta framåt vectorn gånger speed variabeln gånger "Time.deltatime"
        //Jag använder Time.deltatime här för att se till så att farten är konstant oberoende av framerate
        transform.position += transform.forward * speed * Time.deltaTime;

        //Sedan sätts objektets rotation till 0, annars händer konstiga saker med spriten
        transform.rotation = Quaternion.identity;

        //Här flippas objektets sprite så att den alltid kollar mot spelaren
        if(playerpos.position.x >= transform.position.x){
           spriteR.flipX = true;
        }
        else{
           spriteR.flipX = false;
        }
    }
}
