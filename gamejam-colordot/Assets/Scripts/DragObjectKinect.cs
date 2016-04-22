using UnityEngine;
using System.Collections;

public class DragObjectKinect : MonoBehaviour {

    public GameObject HandL;
    public GameObject HandR;

	// Use this for initialization
	private Vector3 screenPoint;
	private Vector3 offset;
	private Vector3 positionBeforeDrag;

    private bool grabbedL;
    private bool grabbedR;

    void Update ()
    {
        if (!grabbedL && !grabbedR)
        {
            if (HandL.transform.position.x > this.transform.position.x - 0.5f &&
                HandL.transform.position.x < this.transform.position.x + 0.5f &&
                HandL.transform.position.y > this.transform.position.y - 0.5f &&
                HandL.transform.position.y < this.transform.position.y + 0.5f &&
                HandL.GetComponent<HandControll>().Opgepakt == false)
            {
                MoveDown(HandL.transform.position.x, HandL.transform.position.y);
                HandL.GetComponent<HandControll>().Opgepakt = true;
                grabbedL = true;
            }

            if (HandR.transform.position.x > this.transform.position.x - 0.5f &&
                HandR.transform.position.x < this.transform.position.x + 0.5f &&
                HandR.transform.position.y > this.transform.position.y - 0.5f &&
                HandR.transform.position.y < this.transform.position.y + 0.5f &&
                HandR.GetComponent<HandControll>().Opgepakt == false)
            {
                MoveDown(HandR.transform.position.x, HandR.transform.position.y);
                HandR.GetComponent<HandControll>().Opgepakt = true;
                grabbedR = true;
            }
        }

        if (grabbedL)
        {
            MoveDrag(HandL.transform.position.x, HandL.transform.position.y);
        }
        if (grabbedR)
        {
            MoveDrag(HandR.transform.position.x, HandR.transform.position.y);
        }
    }

	void MoveDown(float inputX, float inputY){
		positionBeforeDrag = this.transform.position;
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(inputX, inputY, screenPoint.z));
	}

	void MoveDrag(float inputX, float inputY){

        transform.position = new Vector3(inputX, inputY, transform.position.z);
	}

	void MoveUp(){
		this.transform.position = positionBeforeDrag;
	}

}
