using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isGrounded;
    public bool isJump;
    public bool isDead;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJump = false;
        isDead = false;
    }

    void Update()
    {
        // check the ground for so that there are no multiple jumps
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // jumping options
        if(Input.GetKeyDown(KeyCode.Alpha1) && isGrounded){
            rb.velocity = new Vector3(0,7.5f,0);
            isJump = true;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) && isGrounded){
            rb.velocity = new Vector3(0,9.5f,0);
            isJump = true;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3) && isGrounded){
            rb.velocity = new Vector3(0,11.5f,0);
            isJump = true;
        }
    }

    //to decide based on the tag of the place where it interacts
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Platform")){
            isJump = false;
        }
        if(other.gameObject.CompareTag("Obstacle")){
            isDead = true;
        }
        if(other.gameObject.CompareTag("Collectable")){
            gameManager.score += 1;
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("Score")){
            gameManager.score += 1;
            Destroy(other.gameObject);
        }
    }
}
