using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillCooldown : MonoBehaviour
{

    public Image img;
    public GameObject player;
    void Update()
    {
        //Gör fillamount som är hur mycket av lådan som är svart till hur mycket av cooldownen som är kvar
        img.fillAmount = player.GetComponent<ShootBullet>().Cooldown / player.GetComponent<ShootBullet>().Cooldown_time;
    }
}
