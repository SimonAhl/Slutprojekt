using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{

    public GameObject bullet;
    void Update()
    {
        //När man klickar vänsterklick spawnas en bullet på spelarens position utan rotation
        //Y-positionen är lite längre ned för att matcha med spriten av skottet
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.y), Quaternion.identity);
        }
    }
}
