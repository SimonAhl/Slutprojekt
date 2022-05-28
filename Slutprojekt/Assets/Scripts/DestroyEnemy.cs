using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{

    public GameObject Counter;

    //När objektet kommer i kontakt med en trigger som har taggen "Enemy" förstör den objektet som triggern är knuten till och sig själv
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Enemy")){
            Destroy(other.gameObject);

            //Förstör endast detta objekt om den inte har taggen "Wave"
            if(!gameObject.CompareTag("Wave")){
                Destroy(gameObject);
            }

            //Ökar variablen enemiesKilled med 1, den kontrollerar hur ofta fiender spawnas
            GameObject.Find("Master").GetComponent<SpawnEnemies>().enemiesKilled++;


            //Ökar variablen kills med 1 i KillCounter texten och sedan sätter texten till det nya värdet

            Counter = GameObject.Find("KillCounter");

            Counter.GetComponent<NumberOfKills>().kills++;

            Counter.GetComponent<Text>().text = Counter.GetComponent<NumberOfKills>().kills.ToString();
        }
    }
}
