using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] duck;
    float ranY;
    float ranX;
    Vector2 whereToSpawn;
    public float spawnRate = 1f;
    public float nextSpawn = 1f;




    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn&& !ScoreGenerator.win)
        {
            nextSpawn = Time.time + spawnRate;
            ranY = Random.Range(-9f, 9f);
            ranX = Random.Range(-20f, 20f);
            whereToSpawn = new Vector2(ranX, ranY);

            Instantiate(duck[Random.Range(0, duck.Length)], whereToSpawn, Quaternion.identity);
        }
    }
}