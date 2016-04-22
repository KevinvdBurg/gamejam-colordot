using UnityEngine;
using System.Collections;

public class Colorcontroller : MonoBehaviour {
	public Gamecontroller gamecontroller;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gamecontroller.GameStarted) {
			transform.RotateAround(Vector3.zero, Vector3.zero, 20 * Time.deltaTime); 
			Quaternion q = transform.rotation;
			transform.RotateAround(Vector3.zero, Vector3.forward, 20 *Time.deltaTime);
			transform.rotation = q;
		}
	}
}
