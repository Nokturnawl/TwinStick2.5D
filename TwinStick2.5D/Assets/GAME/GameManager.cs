﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool recording = true;

	private bool isPaused = false;
	private float initialFixedDeltaTime;

	void Start () {
		PlayerPrefsManager.UnlockLevel (1);
		print (PlayerPrefsManager.IsLevelUnlocked (1));
		print (PlayerPrefsManager.IsLevelUnlocked (2));
		initialFixedDeltaTime = Time.fixedDeltaTime;
		print (initialFixedDeltaTime);
	}

	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton("Fire1")) {
			recording = false;
		} else {
			recording = true;
		}
		if (Input.GetKeyDown (KeyCode.P)  && isPaused) {
			isPaused = false;
			ResumeGame ();
		} else if (Input.GetKeyDown (KeyCode.P) && !isPaused) {
			isPaused = true;		
			PauseGame ();
		}
	}

	void PauseGame () {
		Time.timeScale = 0;
		Time.fixedDeltaTime = 0;
	}

	void ResumeGame () {
		Time.timeScale = 1f;
		Time.fixedDeltaTime = initialFixedDeltaTime;
	}
}
