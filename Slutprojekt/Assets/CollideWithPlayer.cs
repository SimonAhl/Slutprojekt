using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{

    public float damage;

    //När objektet colliderar med spelaren callar den metoden "PlayerHit" och ger den värdet damage
    //PlayerHit hanterar spelarens skade beräkningar ned spelaren kolliderar med fiender
    void OnTriggerStay2D(Collider2D other) {

        other.GetComponent<EnemyCollision>().PlayerHit(damage);
        
    }

    
}
