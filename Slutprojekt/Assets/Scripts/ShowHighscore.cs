using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighscore : MonoBehaviour
{
    public static int Highscore = 0;

    public GameObject newHigh;

    void Start()
    {
        if(NumberOfKills.kills > Highscore){
            Highscore = NumberOfKills.kills;
            newHigh.SetActive(true);
        }
        else{
            newHigh.SetActive(false);
        }

        GetComponent<Text>().text = Highscore.ToString();
    } 
}
