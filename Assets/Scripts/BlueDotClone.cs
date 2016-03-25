using UnityEngine;
using System.Collections;

public class BlueDotClone : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = gameObject.transform.position;
		pos.z = -0.1f;
		gameObject.transform.position = pos;
	}

	void OnMouseDown () {
		
		if (Background.ChosenColor == "dotted") {
			Background.DottedDotClone = Instantiate (Background.DottedDotGameObject, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			Background.DottedDotClone.tag = "Dotted";
			Background.DottedTag = GameObject.FindGameObjectsWithTag ("Dotted");
			Destroy (gameObject);
		} else if (Background.ChosenColor == "gray") {
			Instantiate (Background.GrayDotGameObject, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject);
		} else if (Background.ChosenColor == "running") {
			Background.ChosenTag = GameObject.FindGameObjectsWithTag ("Chosen");
			for (int i = 0; i < Background.ChosenTag.Length; i++) {
				GameObject BlueObjectClone;
				BlueObjectClone = Instantiate (Background.BlueDotGameObject, Background.ChosenTag [i].transform.position, Background.ChosenTag [i].transform.rotation) as GameObject;
				BlueObjectClone.transform.parent = Background.BlueObject.transform;
				Destroy (Background.ChosenTag [i]);
			}
			GameObject ChosenObjectClone;
			ChosenObjectClone = Instantiate (Background.ChosenDotGameObject, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			ChosenObjectClone.transform.parent = Background.BlueObject.transform;
			Destroy (gameObject);

		}
	}



}
