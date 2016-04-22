using UnityEngine;
using System.Collections;

public class Empty : MonoBehaviour {

	public MixController mixController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		SelectObject ();
	}

	public void SelectObject(){
		mixController.currentColors.Clear ();
	}
}
