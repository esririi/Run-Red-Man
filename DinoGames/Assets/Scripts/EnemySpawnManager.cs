using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    
    [SerializeField] private GameObject[] enemies;

    private Vector2 spawnPoint;
    public float timer;


    private void Start()
    {
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }


    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            EnemySpawn();
            
            timer = Random.Range(1, 4);
        }
        
    }

    private void EnemySpawn()
    {
        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPoint,Quaternion.identity);
    }

}
