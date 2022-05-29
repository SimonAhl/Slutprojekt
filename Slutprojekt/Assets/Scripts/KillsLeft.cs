using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsLeft : MonoBehaviour
{

    void Update()
    {
        
        //Nummret som visas är hur många kills man har kvar tills wave attacken låses upp
        GetComponent<Text>().text = (20 - NumberOfKills.kills).ToString();
        

        if(NumberOfKills.kills >= 20){
            Destroy(gameObject);
        }
    }
}
