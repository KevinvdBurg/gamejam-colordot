using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gamecontroller : MonoBehaviour {

	public List<GameObject> allColors;
	public CColor NeededColor;

	// Use this for initialization
	void Start () {
		newColor ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void newColor(){
		GameObject go = allColors[Random.Range (0, allColors.Count)];
		NeededColor = go.GetComponent<CColor> ();
	}
}
