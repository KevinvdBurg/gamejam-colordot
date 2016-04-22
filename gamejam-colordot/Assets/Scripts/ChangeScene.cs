using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(5);
        Application.LoadLevel("PlayScreen");
    }
    public void GoToPlay()
    {
        Application.LoadLevel("Kevin-Scene");
    }
    public void GoToEnd()
    {
        Application.LoadLevel("PlayScreen");
    }
    // Update is called once per frame
    void Update () {
	
	}
}
