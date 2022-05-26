using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject Quick_enemy;
    public GameObject enemy;
    public float spawn = 0;
    public float spawnTime = 2;

    public float Q_chance = 5;
    public int enemiesKilled = 0;
    void Update()
    {
        //Sänk tiden som det tar för fiender att spawna med 25% varje 10 fiender som dör
        //Ökar chansen att en snabbare variant av den vanliga fienden spawnas
        if(enemiesKilled >= 10){
            enemiesKilled = 0;
            spawnTime = spawnTime * 0.75f;
            Q_chance = Q_chance * 1.25f;
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
