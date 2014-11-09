using UnityEngine;
using System.Collections;

public class Circle_point : MonoBehaviour {
	float ReactionTime=2f;
	GameObject GameMechanicsObject;
	public int Score;

	
	// Use this for initialization
	void Start () {
		GameMechanicsObject = GameObject.Find ("GameMechanics");
	}
	
	// Update is called once per frame
	void Update () {
		ReactionTime -= Time.fixedDeltaTime;
		if (ReactionTime <= 0) {
			GameMechanicsObject.SendMessage("CheckIfReactionTimeWasFastEnough");

		}
	
	}

	public void Destroy_Circle(){
		// Destroys Object
		GameMechanicsObject.SendMessage("UpdateScore");

		Destroy (this.gameObject);//reference to current object
	}
}
