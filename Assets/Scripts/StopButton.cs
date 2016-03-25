using UnityEngine;
using System.Collections;

public class StopButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Stop() {
		Background.ChosenColor = "";
		Destroy (gameObject);
		GameObject ChosenTag = GameObject.FindGameObjectWithTag ("Chosen");
		Instantiate (Background.PlayButton, gameObject.transform.position, gameObject.transform.rotation);
		if (GameObject.FindGameObjectWithTag("Chosen") != null) {
			Instantiate (Background.BlueDotGameObject, ChosenTag.transform.position, gameObject.transform.rotation);
		}
		Destroy (ChosenTag);
		Background.BlueTag = GameObject.FindGameObjectsWithTag ("Blue");
		for (int i = 0; i < Background.BlueTag.Length; i++) {
			Destroy (Background.BlueTag [i]);
			GameObject BlueObjectClone;
			BlueObjectClone = Instantiate (Background.BlueDotGameObject, Background.BluePos [i], gameObject.transform.rotation) as GameObject;
			BlueObjectClone.transform.parent = Background.BlueObject.transform;
		}
		Background.Moves = 0;

	
	}

	void OnMouseDown() {
		Stop ();
		Background.FilledTag = GameObject.FindGameObjectsWithTag ("Filled");
		for (int i = 0; i < Background.FilledTag.Length; i++) {
			Instantiate (Background.GrayDotGameObject, Background.FilledTag [i].transform.position, gameObject.transform.rotation);
			Destroy (Background.FilledTag [i]);
		}
	}
}
