using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{

    public GameObject bullet;

    public float Cooldown;
    public float Cooldown_time;
    void Update()
    {
        //När man klickar vänsterklick spawnas en bullet på spelarens position utan rotation
        //Y-positionen är lite längre ned för att matcha med spriten av skottet
        //Kan endast hända när Cooldown är mindre eller lika med 0
        if(Input.GetKeyDown(KeyCode.Mouse0) && Cooldown <= 0){
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y - 0.3f, 0), Quaternion.identity);
            Cooldown = Cooldown_time;
        }

        //Sänker konstant Cooldownen
        if(Cooldown > 0){
            Cooldown -= 1.2f * Time.deltaTime;
        }
    }
}
