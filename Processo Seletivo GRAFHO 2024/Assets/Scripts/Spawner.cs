using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawns;

    private float currentSpawnTime;
    private int score;
    private float MaxTimeBetweenSpawns = 2;
    private bool dead;

    void Start()
    {
        currentSpawnTime = MaxTimeBetweenSpawns;
    }

    void Update()
    {
        dead = Player.dead;
        currentSpawnTime -= Time.deltaTime;

        if (currentSpawnTime <= 0 && !dead)
        {
            SpawnEnemy();
        }

        score = Sword.score;

        if (score >= 5)
        {
            MaxTimeBetweenSpawns = 1.5f;
        }
        else if (score >= 15)
        {
            MaxTimeBetweenSpawns = 2f;
        }
        else if (score >= 30)
        {
            MaxTimeBetweenSpawns = 4f;
        }
    }

    private void SpawnEnemy()
    {
        int randomPoint = Random.Range(0, spawns.Length);
        Instantiate(enemy, spawns[randomPoint].position, Quaternion.identity);
        currentSpawnTime = MaxTimeBetweenSpawns;
    }
}