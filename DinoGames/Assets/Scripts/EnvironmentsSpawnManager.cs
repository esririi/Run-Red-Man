using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentsSpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] environments;

    private Vector2 spawnPoint;
    public float timer;
    public float environmentSpeed;
    public float destroyTime;


    private void Start()
    {
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }


    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            EnvironmentsSpawn();

            timer = Random.Range(2, 6);
        }

    }


    private void EnvironmentsSpawn()
    {
        GameObject newObject = Instantiate(environments[Random.Range(0, environments.Length)], spawnPoint, Quaternion.identity);
        Rigidbody2D rb = newObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(environmentSpeed, 0);
        Destroy(newObject, destroyTime);
    }
}
