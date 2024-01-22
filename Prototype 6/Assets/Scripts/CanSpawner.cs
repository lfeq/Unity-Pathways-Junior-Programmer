using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSpawner : MonoBehaviour {
    public GameObject canPrefab;

    // Start is called before the first frame update
    private void Start() {
        InvokeRepeating("SpawnCan", 0.5f, 2);
    }

    private void SpawnCan() {
        Instantiate(canPrefab, transform.position, Quaternion.identity);
    }
}