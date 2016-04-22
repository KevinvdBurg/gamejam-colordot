using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class MixController : MonoBehaviour {

	public Gamecontroller gamecontroller;
	//public List<CColor> currentColors;
	public Dictionary<string, int> currentColors;


	// Use this for initialization
	void Start () {
		ResetColor ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		currentColors[other.GetComponentInChildren<CColor> ().Name] += 1;

//		string output = "";
//		foreach (CColor item in currentColors) {
//			output += item.Name;
//		}
//
//		Debug.Log (output);
		if (CheckColors ()) {
			this.GetComponent<Renderer> ().material.color = gamecontroller.NeededColor.color;
		}

	}
		
	bool CheckColors(){
		var needed = gamecontroller.NeededColor;
		Dictionary<string, int> d = new Dictionary<string, int>();
		d = needed.getColorAmount ();

		foreach (var item in d) {
			if (item.Key == "Color Red") {
				foreach (var item2 in currentColors) {
					if (item2.Key == "Red") {
						if (item.Value != item2.Value) {
							return false;
						}
					}
				}
			}
			if (item.Key == "Color Yellow") {
				foreach (var item2 in currentColors) {
					if (item2.Key == "Yellow") {
						if (item.Value != item2.Value) {
							return false;
						}
					}
				}
			}
			if (item.Key == "Color Blue") {
				foreach (var item2 in currentColors) {
					if (item2.Key == "Blue") {
						if (item.Value != item2.Value) {
							return false;
						}
					}
				}
			}
	
		}

		return true;
	}

	bool checkEa(Dictionary<string, int> dict, Dictionary<string, int> dict2){
		bool equal = false;
		if (dict.Count == dict2.Count) // Require equal count.
		{
			equal = true;
			foreach (var pair in dict)
			{
				int value;
				if (dict2.TryGetValue(pair.Key, out value))
				{
					// Require value be equal.
					if (value != pair.Value)
					{
						equal = false;
						break;
					}
				}
				else
				{
					// Require key be present.
					equal = false;
					break;
				}
			}
		}
		return equal;
	}

	public void ResetColor(){
		currentColors = new Dictionary<string, int>();
		currentColors ["Red"] = 0;
		currentColors ["Yellow"] = 0;
		currentColors ["Blue"] = 0;
	}
}