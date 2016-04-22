using UnityEngine;
using System.Collections;

public class DragObject : MonoBehaviour {

	// Use this for initialization
	private Vector3 screenPoint;
	private Vector3 offset;
	private Vector3 positionBeforeDrag;

	void OnMouseDown()
	{
		MoveDown (Input.mousePosition.x, Input.mousePosition.y);
	}

	void OnMouseDrag()
	{
		MoveDrag (Input.mousePosition.x, Input.mousePosition.y);
	}

	void OnMouseUp(){
		MoveUp ();
	}

	void MoveDown(float inputX, float inputY){
		positionBeforeDrag = this.transform.position;
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(inputX, inputY, screenPoint.z));
	}

	void MoveDrag(float inputX, float inputY){
		Vector3 curScreenPoint = new Vector3(inputX, inputY, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint);
		transform.position = curPosition;
	}

	void MoveUp(){
		this.transform.position = positionBeforeDrag;
	}

}
