using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 5f;

    private void Update() {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(direction, 0, 0) * speed * Time.deltaTime);
    }
}