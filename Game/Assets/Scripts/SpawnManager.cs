using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float startDelay = 2;
    private float repeatRate = 2;
    private float spawnRangeY = 5;
    //private float spawnPosY = 3;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    //Update is called once per frame
    void Update()
    {
        
    }

    // This functions activates when the game hasn't detect you hitting Bullet-Bill and will contine spawning Bullet-Bill til you hit him and it will stop spawning them
    void SpawnObstacle ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(0, 0), Random.Range(-spawnRangeY, spawnRangeY));
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        //if (playerControllerScript.gameOver == false)
        //{

        //}
    }
}
