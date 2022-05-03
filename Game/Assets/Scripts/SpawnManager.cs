using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 Center;
    public Vector3 Size;
    private Vector3 spawnPos = new Vector3(5, 2, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    //private float spawnRangeY = 10;
    //private float spawnPosZ = 0;
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

    // This functions activates when
    void SpawnObstacle ()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
