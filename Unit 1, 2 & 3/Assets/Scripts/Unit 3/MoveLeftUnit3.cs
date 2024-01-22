using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftUnit3 : MonoBehaviour {
    private float speed = 30f;
    private PlayerControllerUnit3 playerController;
    private float leftBound = -15f;

    private void Start() {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerUnit3>();
    }

    private void Update() {
        if (!playerController.gameOver) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) {
            Destroy(gameObject);
        }
    }
}