﻿using UnityEngine;

namespace Challenge2 {

    public class PlayerControllerX : MonoBehaviour {
        public GameObject dogPrefab;

        // Update is called once per frame
        private void Update() {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space)) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}