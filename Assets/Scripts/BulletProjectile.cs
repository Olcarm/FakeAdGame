using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50f;
    [SerializeField] private float rayCastRange;

    private void Update()
    {
        HandleMovement();

        Destroy(gameObject, .7f);
    }

    private void HandleMovement()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

    }


    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<EnemyHealthManager>().RecieveDamage(10);
        }
    }

}
