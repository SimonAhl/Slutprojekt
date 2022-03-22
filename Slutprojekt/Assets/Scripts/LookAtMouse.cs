using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    void Update()
    {       

             //musen position
             var mouse = Input.mousePosition;

             //positionen av detta objektet relativt till kameran
             var screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);

             //skillnaden mellan dessa två
             var offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

             //räknar ut vinkeln mellan offsetsen och konverterar det från radianer till grader
             var angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

             //sätter rotationen av objektet till vinkeln minus 90 grader
             transform.rotation = Quaternion.Euler(0, 0, angle + 90);
             
    }
}
