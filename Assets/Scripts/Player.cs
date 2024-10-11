using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private Transform bulletPrefab;

    [SerializeField] private Transform bulletSpawnPoint;

    private float fireRate = .25f;
    private float lastShot= 0f;
    private void Update()
    {

        FireBullet();

    }

    private void FireBullet(){
        if(Time.time > fireRate + lastShot){
            
            Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
            lastShot = Time.time;
        }
    }

}
