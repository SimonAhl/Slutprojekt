using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTutorial : MonoBehaviour
{
    public void TutorialOnClick(){
        SceneManager.LoadScene("TutorialScene");
    }
}
