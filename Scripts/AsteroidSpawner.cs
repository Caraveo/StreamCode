using System.Collections;
using System.Collections.Generic;
using UnityEngine;

# Asteroid Stream from Twitch.tv/JohnnyHypeCar

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroids;
    public int numAsteroids;

    public int radius;


    private void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        for (int a = 0; a < numAsteroids; a++)
        {
            int rangeNum = Random.Range(0, asteroids.Length);

            Vector3 randomVec = new Vector3(Random.Range(-radius, radius), Random.Range(-radius, radius), Random.Range(-radius, radius));

            Instantiate(asteroids[rangeNum], randomVec, Random.rotation);
        }
    }
}
