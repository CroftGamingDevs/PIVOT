using UnityEngine;
using System.Collections;

public class DottedDot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Background.ChosenColor == "running") {
			GetComponent<Renderer> ().enabled = false;
		} else {
			GetComponent<Renderer> ().enabled = true;
		}
	}
	void OnMouseDown () {
		// 	When the user clicks the dotted dot, his/her chosen color changes to dotted, 
		//	which then changes their cursor to a dotted dot. 
		// 	See Background.cs for more info.
		if (Background.ChosenColor != "running") {
			Background.ChosenColor = "dotted";
		}
	}
}
