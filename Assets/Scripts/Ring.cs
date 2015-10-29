using UnityEngine;
using System.Collections;

public class Ring : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag.Equals ("Barreira")) {
			Application.LoadLevel (Application.loadedLevel);
		}
		if (other.gameObject.tag.Equals ("Star")) {
			Destroy(other.gameObject);
		}
	}


}
