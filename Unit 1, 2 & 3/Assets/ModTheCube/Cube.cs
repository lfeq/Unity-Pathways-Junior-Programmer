using UnityEngine;

public class Cube : MonoBehaviour {
    public MeshRenderer Renderer;
    public Vector3 position = Vector3.zero;
    public Vector3 scale = Vector3.one;
    public float rotationSpeed = 10.0f;

    private Material material;

    private void Start() {
        transform.position = position;
        transform.localScale = scale;

        material = Renderer.material;

        InvokeRepeating("ChangeColor", 2, 5);
    }

    private void Update() {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f);
    }

    private void ChangeColor() {
        float r = Random.value;
        float g = Random.value;
        float b = Random.value;
        float a = Random.value;
        material.color = new Color(r, g, b, a);
    }
}