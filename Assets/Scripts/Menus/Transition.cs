using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {
	public bool pause = true;

	public static void Menu(){ 
		Application.LoadLevel ("Menu");
	}

	public void About2Menu(){ 
		Application.LoadLevel ("Menu");
	}

	public void About(){
		Application.LoadLevel("About");
	}

	public void Stage1(){
		Application.LoadLevel("Stage 1");
	}	

	public void Select(){
		Application.LoadLevel("SelectLevel");
	}

	public void Pause(){
		if (pause) {
			Time.timeScale = 0;
			Application.LoadLevel("Pause");
			pause = false;
		} else {
			Stage1();
			Time.timeScale = 1;
			pause = true;
		}
	}
}
