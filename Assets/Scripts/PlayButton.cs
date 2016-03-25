using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Background.ChosenColor = "running";
		Destroy (gameObject);
		Instantiate (Background.StopButton, gameObject.transform.position, gameObject.transform.rotation);
		Background.BlueTag = GameObject.FindGameObjectsWithTag ("Blue");
		Background.BluePos = new Vector3[Background.BlueTag.Length];
		for (int i = 0; i < Background.BlueTag.Length; i++) {
			Background.BluePos[i] = Background.BlueTag [i].transform.position;
		}
		Background.BlueTag = GameObject.FindGameObjectsWithTag ("Blue");
		for (int i = 0; i < Background.BlueTag.Length; i++) {
			Vector3 pos = Background.BlueTag [i].transform.position;
			Vector3 newpos = new Vector3 (pos.x, pos.y, 0.0f);
			Instantiate (Background.FilledDotGameObject, newpos, gameObject.transform.rotation);
		}
	}
}
