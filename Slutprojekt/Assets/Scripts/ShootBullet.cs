using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{

    public GameObject bullet;

    public GameObject wave;

    public GameObject KillCounter;

    //Cooldown timer och time för vanliga attacken
    public float Cooldown;
    public float Cooldown_time;

    //Cooldown timer och time för wave attacken
    public float W_Cooldown;
    public float W_Cooldown_Time;
    void Update()
    {
        //När man klickar vänsterklick spawnas en bullet på spelarens position utan rotation
        //Y-positionen är lite längre ned för att matcha med spriten av skottet
        //Kan endast hända när Cooldown är mindre eller lika med 0
        if(Input.GetKeyDown(KeyCode.Mouse0) && Cooldown <= 0){
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y - 0.3f, 0), Quaternion.identity);
            Cooldown = Cooldown_time;
        }


        //Man kan endast använda wave attacken om man har mer än 20 kills
        if(KillCounter.GetComponent<NumberOfKills>().kills >= 20){

            //Samma sak som ovan fast med wave attacken och med högerclick iställer för vänsterclick
            if(Input.GetKeyDown(KeyCode.Mouse1) && W_Cooldown <= 0){
                Instantiate(wave, new Vector3(transform.position.x, transform.position.y - 0.3f, 0), Quaternion.identity);
                W_Cooldown = W_Cooldown_Time;
            }
        }



        //Sänker konstant Cooldownen
        if(Cooldown > 0){
            Cooldown -= 1.2f * Time.deltaTime;
        }

        //Sänker konstant wave cooldownen
        if(W_Cooldown > 0){
            W_Cooldown -= 1.2f * Time.deltaTime;
        }
    }
}
