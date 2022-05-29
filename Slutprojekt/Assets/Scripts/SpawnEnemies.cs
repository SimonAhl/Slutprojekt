using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject Quick_enemy;
    public GameObject enemy;
    public float spawn = 0;
    public float spawnTime = 2;
    public float initSpawn = 2;

    public int logBase = 1;

    public float Q_chance = 5;
    public float initQ_chance = 5;
    public int enemiesKilled = 0;
    void Update()
    {

        //Ökar chansen att en snabbare variant av den vanliga fienden spawnas
        if(enemiesKilled >= 10){


            //Sänk tiden som det tar för fiender att spawna varje 10 fiender som dör
            //Detta gör jag på ett logaritmiskt sätt för att enligt min erfarnhet brukar logaritmisk svårighet vara det mest intressanta och utmanande
            logBase++;
            spawnTime = initSpawn / Mathf.Log(logBase + 1, 1.1f);

            //Ökar chansen för en snabb version av fienden att spawna, även logaritmiskt
            Q_chance = initQ_chance * Mathf.Log(logBase + 1, 1.3f);

            
            enemiesKilled = 0;
        }

        //Om spawntimern är mindre eller lika med noll spawnas en fiende på en random plats på spelplanen som inte är nära spelaren utan rotation
        //Sedan sätts spawntimern till spawnTime igen
        if(spawn <= 0){

            Transform playerpos = GameObject.Find("Player").transform;

            Vector3 spawnLoc;

            bool fail;

            do{

                fail = false;

                //Väljer en spawn position
                spawnLoc = new Vector3(Random.Range(-29, 19), Random.Range(-29.5f, 12.5f), 0);

                
                //Om spawn positionens x eller y kordinater är för nära spelaren väljs en ny tills en som inte är nära spelarens har hittats

                if(spawnLoc.x < playerpos.position.x + 7 && spawnLoc.x > playerpos.position.x - 7){
                    fail = true;
                }

                if(spawnLoc.y < playerpos.position.y + 10 && spawnLoc.y > playerpos.position.y - 10){
                    fail = true;
                }

            }while(fail);

            //Varje fiende som spawnas har en chans att vara en snabbare variant
            if(Random.Range(0, 100) <= Q_chance){
                Instantiate(Quick_enemy, spawnLoc, Quaternion.identity);
            }else{
                
                 //Spawnar en vanlig fiende
                 Instantiate(enemy, spawnLoc, Quaternion.identity);
            }
            spawn = spawnTime;
        }

        //Spawn timern tickar konstant ned när den är mer än noll
        //Gånger Time.deltaTime så det inte varierar beroende på framerate
        if(spawn > 0){
            spawn -= 1.2f * Time.deltaTime;
        }
    }
}
