using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    //När objektet kommer i kontakt med en trigger som har taggen "Enemy" förstör den objektet som triggern är knuten till och sig själv
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Enemy")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
