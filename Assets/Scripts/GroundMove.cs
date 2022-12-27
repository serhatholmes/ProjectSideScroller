using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
       void Update()
    {
        // platform moving to make you feel like you're moving forward
        transform.position -= new Vector3(6*Time.deltaTime, 0, 0);
        if(transform.position.x <= -9){
            transform.position = new Vector3(9f,transform.position.y,0f); 
        }
    }
}
