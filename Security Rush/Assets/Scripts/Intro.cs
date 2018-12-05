﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	public float time = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time>22) {
			SceneManager.LoadScene ("Menu");
		}
	}

	public void LoadMenu(){
		SceneManager.LoadScene ("Menu");
	}
}