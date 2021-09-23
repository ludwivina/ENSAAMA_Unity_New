using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    public float speed = 5f;
    public float jumpSpeed = 16f;
    public float jumpCoolDown = 0f;

    // Update is called once per frame
    void Update()
    {  
       //Pour bouger le cube avec les touches du clavier :
       
        Rigidbody body = GetComponent<Rigidbody>();
        
        Vector3 move = new Vector3();
        
        move.x = speed * Input.GetAxis("Horizontal");
        move.y = body.velocity.y;
        move.z = speed * Input.GetAxis("Vertical");
        
        body.velocity = move;

        jumpCoolDown = jumpCoolDown - Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && jumpCoolDown <= 0) {
            jumpCoolDown = 1f;
            move.y = jumpSpeed;
        }

        body.velocity = move;
    }

}
