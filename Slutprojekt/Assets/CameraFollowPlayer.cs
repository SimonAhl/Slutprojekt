using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform playerPos;

    //Gör så att kameran följer spelaren
    //Har den i LateUpdate så att kameran updateras efter pointern, annars skapar det stuttering i pointern
    void LateUpdate() {

      transform.position = new Vector3(playerPos.position.x, playerPos.position.y, -10);

    }
}
