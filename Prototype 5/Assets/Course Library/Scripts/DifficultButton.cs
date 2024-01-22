using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultButton : MonoBehaviour {
    private Button button;
    private GameManager gameManager;
    public int difficulty;

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void SetDifficulty() {
        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame(difficulty);
    }
}