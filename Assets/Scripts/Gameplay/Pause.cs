using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public Canvas pauseCanvas;
	public bool pause = false;


	// Use this for initialization
	void Start () {
		pauseCanvas = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		if (pause) {
			Time.timeScale = 0;
			pauseCanvas.enabled = true;
			pause = false;
		}
	}

	public void PauseGame(){
		pause = true;
	}
}
