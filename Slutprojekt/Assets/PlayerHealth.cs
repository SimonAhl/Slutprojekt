using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 100;

    public GameObject healthbar;


    //Sätter healthbarens startvärde till spelarens health startvärde
    void Start() {
        healthbar.GetComponent<Slider>().maxValue = playerHealth;
    }

    void Update(){

        //Updaterar healthbaren till spelarens health värde
        healthbar.GetComponent<Slider>().value = playerHealth;
    }
}
