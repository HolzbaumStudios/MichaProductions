using UnityEngine;
using System.Collections;

public class GameMechanicsScript : MonoBehaviour {


	int PositionX;
	int PositionY;
	bool TimerForNextCircle = true;
	bool ReactionTimeFailure = false;
	int Score=0;
	float TimeFromOneCircleToNext;

	
	public GameObject OrangeCircle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (ReactionTimeFailure) {
			PlayerPrefs.SetInt("Player Score", Score);
			Application.LoadLevel("GameOverScene");
					
				} else {


						if (TimerForNextCircle) {

								StartCoroutine (getTimeconstraint ());
								getRandomScreenPosition ();
								PopUpCircle ();
						}
				}
	}
	void getRandomScreenPosition(){

		PositionX = Random.Range(-350,350);
		PositionY = Random.Range(-100,100);


	}

	IEnumerator getTimeconstraint(){
		TimerForNextCircle = false;
		getTimeForNextCircle ();
		yield return new WaitForSeconds (TimeFromOneCircleToNext);
		TimerForNextCircle = true;
	
	}
	void getTimeForNextCircle(){
		TimeFromOneCircleToNext = Random.Range (0f, 2f);
	}
	public void CheckIfReactionTimeWasFastEnough(){
		ReactionTimeFailure = true;

	}
	void UpdateScore(){
		Score += 1;
		}
	void PopUpCircle()
	{
		GameObject OrangeObject = Instantiate (OrangeCircle,new Vector2(PositionX,PositionY),transform.rotation) as GameObject;
		OrangeObject.transform.parent = GameObject.Find ("Canvas").transform;
		OrangeObject.transform.localPosition = new Vector2 (PositionX, PositionY);
	}
}
