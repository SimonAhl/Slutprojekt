using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillCooldown : MonoBehaviour
{

    public Image img;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        img.fillAmount = player.GetComponent<ShootBullet>().Cooldown;
    }
}
