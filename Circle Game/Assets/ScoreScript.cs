using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	int Score;

	// Use this for initialization
	void Start () {
		Score = PlayerPrefs.GetInt ("Player Score");
		gameObject.GetComponent<Text> ().text = "Your Score was: "+Score.ToString();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
