using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void goBackToMainMenu(){
		Application.LoadLevel ("MainMenuScene");
	}
	public void retryTheGame(){
		Application.LoadLevel ("MainGameScene");
	}
}
