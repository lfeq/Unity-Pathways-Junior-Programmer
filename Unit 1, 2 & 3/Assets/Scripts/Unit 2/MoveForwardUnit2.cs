using UnityEngine;

public class MoveForwardUnit2 : MonoBehaviour {
    public float speed = 40.0f;

    // Update is called once per frame
    private void Update() {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}