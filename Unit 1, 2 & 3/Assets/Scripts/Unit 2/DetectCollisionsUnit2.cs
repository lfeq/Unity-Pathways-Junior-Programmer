using UnityEngine;

public class DetectCollisionsUnit2 : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}