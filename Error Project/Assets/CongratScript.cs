﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour {
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    private List<string> TextToDisplay = new List<string>();
    private float TimeToNextText;
    private int CurrentText;

    // Start is called before the first frame update
    private void Start() {
        TimeToNextText = 0.0f;
        CurrentText = 0;
        TextToDisplay.Add("Congratulations");
        TextToDisplay.Add("All Errors Fixed");
        Text.text = TextToDisplay[0];
        SparksParticles.Play();
    }

    // Update is called once per frame
    private void Update() {
        TimeToNextText += Time.deltaTime;
        if (TimeToNextText > 1.5f) {
            TimeToNextText = 0.0f;
            CurrentText++;
            if (CurrentText >= TextToDisplay.Count) {
                CurrentText = 0;
            }
            Text.text = TextToDisplay[CurrentText];
        }
    }
}