using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighscoreScript : MonoBehaviour {
	int HighScore;
	// Use this for initialization
	void Start () {
		HighScore = PlayerPrefs.GetInt ("Player HighScore");
		gameObject.GetComponent<Text> ().text = "Your Highscore is: "+HighScore.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void goBackToMainMenu(){
		Application.LoadLevel ("MainMenuScene");
	}
}
