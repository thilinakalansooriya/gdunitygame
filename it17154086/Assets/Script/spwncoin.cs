using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwncoin : MonoBehaviour
{
    public GameObject coin;
    public float cmaxX;
    public float cminX;
    public float cmaxY;
    public float cminY;
    public float ctimeBetweenSpawn;
    private float cspawntime;



    // Update is called once per frame
    void Update()
    {
        if (Time.time > cspawntime)
        {

            Spawn();
            cspawntime = Time.time + ctimeBetweenSpawn;
        }
    }
    void Spawn()
    {
        float randomx = Random.Range(cminX, cmaxX);
        float randomY = Random.Range(cminY, cmaxY);

        Instantiate(coin, transform.position + new Vector3(randomx, randomY, 0), transform.rotation);
    }
}
