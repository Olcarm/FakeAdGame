using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private DynamicJoystick dynamicJoystick;

    private Rigidbody rb;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        HandleMovement();
        
    }

    private void HandleMovement()
    {
        Vector3 moveDir = Vector3.right * dynamicJoystick.Horizontal;


        if(transform.position.x <=3.5f){
            if(moveDir.x > 0){
                transform.position += moveDir * speed * Time.deltaTime;
                
            }
        }
        if(transform.position.x >= -3.5f){
            if(moveDir.x < 0){
                transform.position += moveDir * speed * Time.deltaTime;
            }
        }
    }
}
