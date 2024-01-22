using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    private void LateUpdate() {
        transform.position = player.transform.position + offset;
    }
}