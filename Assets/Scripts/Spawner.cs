using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject collectable;
  
    void Start()
    {
        // to determine spawn frequency and speed
        InvokeRepeating("Spawn",1.5f,2.5f);
    }
    void Spawn(){
        // To spawn the small obstacle if the random number is greater than 4, 
        // the large obstacle if it is less than 3, and the collectible item if it is 3 or 4
        int i = Random.Range(1,7);
        if(i>4){
            Instantiate(obstacle1,new Vector3(transform.position.x,0,0),Quaternion.identity);
        }
        else if(i<3){
            Instantiate(obstacle2,new Vector3(transform.position.x,0,0),Quaternion.identity);
        }
        else if(i == 3 || i == 4){
            Instantiate(collectable,new Vector3(transform.position.x,0,0), Quaternion.identity);
        }
    }
}
