using UnityEngine;
using System.Collections;

public class Empty : MonoBehaviour {

	public MixController mixController;
	public Gamecontroller gamecontroller;

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
		mixController.ResetColor ();
		gamecontroller.newColor ();
	}
}
