using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsLeft : MonoBehaviour
{

    public GameObject KillCounter;

    void Update()
    {
        
        //Nummret som visas är hur många kills man har kvar tills wave attacken låses upp
        GetComponent<Text>().text = (20 - KillCounter.GetComponent<NumberOfKills>().kills).ToString();
        

        if(KillCounter.GetComponent<NumberOfKills>().kills >= 20){
            Destroy(gameObject);
        }
    }
}
