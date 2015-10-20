using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject obstacle;
	public float _time;
	//private Score _score;
	// Use this for initialization

	void Start()
	{
		InvokeRepeating("CreateObstacle", 3f, _time);
		//_score = GameObject.FindGameObjectWithTag ("score").GetComponent<Score> ();
	}
	
	void CreateObstacle()
	{
		Instantiate(obstacle);
		//_score.UpScore ();
	}
}
