using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private Rigidbody2D rgbEnemy;
    [SerializeField] private int enemySpeed;


    private void Start()
    {
        rgbEnemy = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rgbEnemy.velocity = new Vector2(-1, -1) * enemySpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="ripper")
        {
            Destroy(this.gameObject);
        }
    }

}
