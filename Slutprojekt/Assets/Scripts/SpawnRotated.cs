using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRotated : MonoBehaviour
{
    GameObject pointer;
    void Start()
    {
        //Hittar pointern som den tar rotationen från
        pointer = GameObject.Find("PointerBase");

        //Sätter objektets rotation till det av pointern, använder eulerAngles för att få tillbaka grader som sedan kna konverteras tillbaka till quaternioner
        transform.rotation = Quaternion.Euler(0, 0, pointer.transform.eulerAngles.z);
    }
}
