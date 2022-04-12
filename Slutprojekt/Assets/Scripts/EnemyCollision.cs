using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    /// <summary>
    /// Hanterar skade beräkningar hos spelaren
    /// </summary>
    public void PlayerHit(float damage){

        GetComponent<PlayerHealth>().playerHealth -= damage;

    }
}
