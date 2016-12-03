using UnityEngine;
using System;
using System.Collections;
using UnityEngine.SceneManagement;

public class EasyButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnMouseDown() {
		Console.WriteLine("That was easy");
		SceneManager.LoadScene ("DifficultyPicker");
		SceneManager.UnloadScene (SceneManager.GetActiveScene());
		SceneManager.SetActiveScene (SceneManager.GetSceneByName("DifficultyPicker"));
	}
}
