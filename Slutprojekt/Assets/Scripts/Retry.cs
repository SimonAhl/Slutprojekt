using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    float clickWait;

    private void Start() {

        clickWait = 1.5f;

    }

    private void Update() {
        if(clickWait > 0)
           clickWait -= Time.deltaTime;
    }



    public void RetryOnClick(){

        //Väntar 1.5 sekunder innan man kan klicka så att man inte klickar av misstag
        if(clickWait <= 0){
            SceneManager.LoadScene("GameScreen");
        }
    }
}
