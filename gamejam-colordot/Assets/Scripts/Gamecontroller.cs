using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour {

	public List<GameObject> allColors;
	public CColor NeededColor;
	public Text currentText;
	public int score;
	public Text scoreText;

	public Text TimeText;
	public float timerTime;
	float maxTime;
	public bool GameStarted = true;
	// Use this for initialization
	void Start () {
		score = 0;
		newColor ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameStarted) {
			timerTime -= Time.deltaTime;

			TimeText.text = "Time Left: " + Mathf.Round(timerTime);
			if (timerTime <= 0.0f)
			{
				GameOver();
			}
		}
	}

	public void newColor(){
		GameObject go = allColors[Random.Range (0, allColors.Count)];
		NeededColor = go.GetComponent<CColor> ();
		currentText.text = NeededColor.Name;
		UpdateUI ();
	}

	public void UpdateUI(){
		scoreText.text = score + "";
	}

	public void GameOver(){
		GameStarted = false;
		Application.LoadLevel("EndingScreen");
	}
}
