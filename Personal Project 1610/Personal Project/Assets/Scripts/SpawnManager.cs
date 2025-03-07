﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject movingRightPlatformPrefab;
    public GameObject movingLeftPlatformPrefab;
    public Vector3 movingRightSpawnLocation;
    public Vector3 movingLeftSpawnLocation;

    private float spawnDelay = 1f;
    private float repeatRate = 3f;

    private GameManager gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
       gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
       InvokeRepeating("SpawnMovingPlatform",spawnDelay,repeatRate); //Activates the SpawnMovingPlatform function on a repeat and delay
    }

    private void SpawnMovingPlatform() //Function that spawns the moving platforms at certain locations
    {
        if(gameManagerScript.isGameOn)
        {
            Instantiate(movingRightPlatformPrefab, movingRightSpawnLocation, movingRightPlatformPrefab.transform.rotation);
            Instantiate(movingLeftPlatformPrefab, movingLeftSpawnLocation, movingLeftPlatformPrefab.transform.rotation); 
        }
    }
}
