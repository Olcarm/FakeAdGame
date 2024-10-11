using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private float timer;
    private float timerMax = 3f;
    [SerializeField] private Transform enemyPrefab;

    private void Start() {
        timer = timerMax;
        SpawnEnemy();
    }

    void Update()
    {

        if(timer >= 0){
            timer -= Time.deltaTime;
        }
        if(timer <=0){
            SpawnEnemy();
            timer = timerMax;
        }
        

    }

    private void SpawnEnemy(){
        float spawnPointRandomX = Random.Range(-3.5f, 3.5f);
        Vector3 spawnPoint = new Vector3(spawnPointRandomX, 0, 40);
        
        Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
    }
}
