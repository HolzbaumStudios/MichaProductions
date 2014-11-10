using UnityEngine;
using System.Collections;

public class MainMenuMechanicsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartNewGame(){
		Application.LoadLevel("MainGameScene");
	}

	public void ViewHighscore(){
		Application.LoadLevel ("ViewHighscoreScene");
	}
	//todo public void ExitGame()
}
