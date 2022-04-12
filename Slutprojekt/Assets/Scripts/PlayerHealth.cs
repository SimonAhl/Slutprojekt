using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 100;

    public GameObject healthbar;
    public float timer = 0;


    void Start() {

        //Sätter healthbarens startvärde till spelarens health startvärde
        healthbar.GetComponent<Slider>().maxValue = playerHealth;
    }

    void Update(){

        //Om spelarens health har ändrats sedan förra framen (blivit skadad eller fått mer)
        //Så sätts timern till 4
        if (healthbar.GetComponent<Slider>().value != playerHealth){
            timer = 4;
        }

        //Om timern är mer än 0 så tas det bort lika mycket tid som sekunder sedan förra framen
        if(timer > 0){
            timer -= Time.deltaTime;
        }

        //Updaterar healthbaren till spelarens health värde
        healthbar.GetComponent<Slider>().value = playerHealth;

        //Om spelarens health är under 20 eller timern är över 0 så visas healthbaren
        //Annars är den osynlig
        if (healthbar.GetComponent<Slider>().value <= 20 || timer > 0){
            healthbar.SetActive(true);
        }else{
            healthbar.SetActive(false);
        }
    }
}
