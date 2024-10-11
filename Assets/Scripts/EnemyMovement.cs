using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    void Update()
    {
        transform.position += -Vector3.forward * moveSpeed * Time.deltaTime;
        
        if(transform.position.z < -22f){
            Destroy(gameObject);
        }
    }
}
