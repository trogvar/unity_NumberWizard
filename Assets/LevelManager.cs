﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log("LevelManager::LoadLevel() called for " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest() {
		Debug.Log ("LevelManager::QuitRequest() called");
		Application.Quit();
	}
}
