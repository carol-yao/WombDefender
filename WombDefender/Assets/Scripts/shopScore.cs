using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shopScore : MonoBehaviour {

	public static int score;


	Text text;

	void Start () {

		text = GetComponent<Text> ();
	}

	// Update is called once per frame

	void Update () {
		

		score = ScoreController.totalScore;

		text.text = "" + score;

	
	}
}
