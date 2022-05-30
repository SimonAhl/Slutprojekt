using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    float init_time;

    private void Start() {
        init_time = Time.time;
    }



    public void RetryOnClick(){

        //Väntar 3 sekunder innan man kan klicka så att man inte klickar av misstag
        if(init_time > Time.time + 3)
        SceneManager.LoadScene("GameScreen");
    }
}
