using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerUnit3 : MonoBehaviour {
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerControllerUnit3 playerControllerUnit3;

    private void Start() {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerUnit3 = GameObject.Find("Player").GetComponent<PlayerControllerUnit3>();
    }

    private void SpawnObstacle() {
        if (!playerControllerUnit3.gameOver) {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}