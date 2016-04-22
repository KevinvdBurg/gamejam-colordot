using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class CColor : MonoBehaviour {

	public string Name;
	public ArrayColors[] Colors;
	public Color color;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	[Serializable]
	public struct ArrayColors {
		public CColor color;
		public int amount;
	}

	public Dictionary<string, int> getColorAmount(){
		Dictionary<string, int> dictionary = new Dictionary<string, int>();

		foreach (var item in Colors) {
			dictionary.Add(item.color.name, item.amount);
		}

		return dictionary;
	}
		
}
