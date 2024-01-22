using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerUnit3 : MonoBehaviour {
    public float jumpForce = 10f;
    public float gravityModifier = 1;
    public bool isOnGround = true;
    public bool gameOver = false;
    public ParticleSystem explotionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    private Rigidbody rb;
    private Animator playerAnim;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    private void Start() {
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
            dirtParticle.Play();
        } else if (collision.gameObject.CompareTag("Obstacle")) {
            gameOver = true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explotionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1f);
        }
    }
}