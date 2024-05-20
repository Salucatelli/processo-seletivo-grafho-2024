using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawns;

    private float currentSpawnTime;
    private int score;
    private float MaxTimeBetweenSpawns = 1.5f;
    public bool dead;

    void Start()
    {
        currentSpawnTime = MaxTimeBetweenSpawns;
    }

    void Update()
    {
        if (Time.time > 3)
        {
            dead = Player.dead;
            currentSpawnTime -= Time.deltaTime;

            if (score >= 5)
            {
                MaxTimeBetweenSpawns = 0.5f;
            }
            else if (score >= 15)
            {
                MaxTimeBetweenSpawns = 0.25f;
            }
            else if (score >= 30)
            {
                MaxTimeBetweenSpawns = 0.15f;
            }

            if (currentSpawnTime <= 0 && dead == false)
            {
                SpawnEnemy();
            }

            score = Sword.score;
        }
    }

    private void SpawnEnemy()
    {
        int randomPoint = Random.Range(0, spawns.Length);
        Instantiate(enemy, spawns[randomPoint].position, Quaternion.identity);
        currentSpawnTime = MaxTimeBetweenSpawns;
    }
}