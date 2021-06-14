using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobttical : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawntime;



    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawntime)
        {

            Spawn();
            spawntime = Time.time + timeBetweenSpawn;
        }
    }
    void Spawn()
    {
        float randomx = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomx, randomY, 0), transform.rotation);
    }
}
