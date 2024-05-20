using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;

    private Transform playerPosition;
    private GameObject playerObject;
    public float enemyVelocity;
    public float distanceToStop;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject != null)
        {
            FollowPlayer();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Destroy(this.gameObject);
        }
    }

    private void FollowPlayer()
    {
        if (playerPosition.gameObject != null && Vector2.Distance(playerPosition.position, transform.position) > distanceToStop)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, enemyVelocity * Time.deltaTime);
        }
    }
}
