using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {
	// Update is called once per frame

	public static void Menu(){ 
		Application.LoadLevel ("Menu");
	}

	public void About2Menu(){ 
		Application.LoadLevel ("Menu");
	}

	public void About(){
		Application.LoadLevel("About");
	}	
}
