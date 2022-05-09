using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float startDelay = 3;
    private float repeatRate = 3;
    private float spawnRangeY = 8;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    // It then Invokes a repeating cycle of spawning in Bullet-Bill
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

        if (playerControllerScript.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(10, Random.Range(spawnRangeY, 0));
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
