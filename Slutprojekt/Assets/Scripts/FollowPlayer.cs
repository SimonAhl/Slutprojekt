using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerPos;
    public float offset;
    void Update()
    {

        //sätter objektets position till spelarens minus en offset för spelarspriten är inte i mitten av objektet
        transform.position = new Vector3(playerPos.position.x, playerPos.position.y - offset, playerPos.position.z);
    }
}
