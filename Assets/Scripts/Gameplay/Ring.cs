using UnityEngine;
using System.Collections;

public class Ring : MonoBehaviour {
	int star = 0;
	public AudioClip ouch;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (star == 3){		
			Application.LoadLevel("Menu");
		}
	}
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag.Equals ("Barreira")) {
			StartCoroutine(DelayedLoad());
		}
		if (other.gameObject.tag.Equals ("Star")) {
			star += 1;
			Destroy(other.gameObject);
		}
	}

	IEnumerator DelayedLoad()
	{		
		audio.PlayOneShot(ouch, 2f);
		yield return new WaitForSeconds(0.25f);		
		Application.LoadLevel("Menu");
	}
}