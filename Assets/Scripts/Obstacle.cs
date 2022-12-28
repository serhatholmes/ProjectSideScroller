using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void Update()
    {
        // to make the spawned obstacles go from right to left
        transform.position -= new Vector3(4f*Time.deltaTime,0,0);
    }
    void OnCollisionEnter2D(Collision2D other){
        //to destroy the obstacles leaving the scene
        if(other.gameObject.tag == "Destroy"){
            //Debug.Log("destroyed");
            Destroy(this.gameObject);
        }
    }
}
