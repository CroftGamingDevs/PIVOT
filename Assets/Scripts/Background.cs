using UnityEngine;
using System.Collections;


public class Background : MonoBehaviour {

	// ChosenColor is used to determine the color of the user's cursor
	// See the if statement below, as well as GrayDot.cs, BlueDot.cs, and DottedDot.cs for more info
	public static Background Current;
	public static string ChosenColor;
	public Texture2D CursorTextureGray;
	public Texture2D CursorTextureBlue;
	public Texture2D CursorTextureDotted; 
	public static GameObject GrayDotGameObject;
	public static GameObject BlueDotGameObject;
	public static GameObject DottedDotGameObject;
	public static GameObject ChosenDotGameObject;
	public static GameObject FilledDotGameObject;
	public static GameObject BlueObject;
	public static GameObject DottedDotClone;
	public static GameObject PlayButton;
	public static GameObject StopButton;
	public static GameObject[] DottedTag;
	public static GameObject[] ChosenTag;
	public static GameObject[] BlueTag;
	public static GameObject[] FilledTag;
	public static GameObject[] GrayTag;
	public static Vector3[] BluePos;
	public static Font Fairview;
	public static int Moves;
	public static GUIStyle CounterStyle;
	public Vector2 MousePos = new Vector2 (20,20);
	public static Color CounterColor = new Color();
	public static string LevelName;
	// Start is called at the beginning of the game
	void Awake() {
		if (Current == null) {
			DontDestroyOnLoad (gameObject);
			Current = this;
		}
	}

	void Start () {
		
		BlueObject = GameObject.Find("BlueObject");
		Fairview = Resources.Load ("Fonts/Fairview") as Font;
		FilledDotGameObject = Resources.Load ("Prefabs/FilledDotPrefab") as GameObject;
		GrayDotGameObject = Resources.Load ("Prefabs/GrayDotPrefab") as GameObject;
		BlueDotGameObject = Resources.Load ("Prefabs/BlueDotPrefab") as GameObject;
		DottedDotGameObject = Resources.Load ("Prefabs/DottedDotPrefab") as GameObject;
		ChosenDotGameObject = Resources.Load ("Prefabs/DotChosen") as GameObject;
		PlayButton = Resources.Load ("Prefabs/PlayButtonPrefab") as GameObject;
		StopButton = Resources.Load ("Prefabs/StopButtonPrefab") as GameObject;
		CursorTextureGray = Resources.Load("Sprites/MouseGray") as Texture2D;
		CursorTextureBlue = Resources.Load("Sprites/MouseBlue") as Texture2D;
		CursorTextureDotted = Resources.Load("Sprites/MouseDotted") as Texture2D;
		DottedTag = GameObject.FindGameObjectsWithTag ("Dotted");
		Moves = 0;
		ColorUtility.TryParseHtmlString ("#AAAAAAFF", out CounterColor);
		CounterStyle = new GUIStyle ();
		CounterStyle.fontSize = 32;
		CounterStyle.font = Fairview;
		CounterStyle.normal.textColor = CounterColor;
		LevelName = "";
	}

	// Update is called once per frame
	void Update () {
		// The user's chosen color is based off of which dot they clicked in either GrayDot.cs, BlueDot.cs, or DottedDot.cs
		// Their chosen color determines the color of the cursor.
		if (ChosenColor == "gray") {
			// Sets the cursor's texture to a gray dot
			Cursor.SetCursor (CursorTextureGray, MousePos, CursorMode.Auto);
		} else if (ChosenColor == "blue") {
			// Sets the cursor's texture to a blue dot
			Cursor.SetCursor(CursorTextureBlue, MousePos, CursorMode.Auto);
		} else if (ChosenColor == "dotted") {
			// Sets the cursor's texture to a dotted dot
			Cursor.SetCursor(CursorTextureDotted, MousePos, CursorMode.Auto);
		} else if (ChosenColor == "running") {
			// Sets the cursor's texture to a dotted dot
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		}
				
	}

	void OnGUI () {
		if (ChosenColor == "running") {
			GUI.Box (new Rect (100, Screen.height - 100, 100, 25), "MOVES: " + Moves.ToString (), CounterStyle);
		}

		LevelName = GUI.TextField(new Rect(50, 50, 100, 25), LevelName, 25);
		if (GUI.Button (new Rect (50, 100, 100, 25), "Save")) {
			SaveLoad.Save ();
		}
		if (GUI.Button (new Rect (50, 150, 100, 25), "Load")) {
			SaveLoad.Load ();
		}

	}
}

[System.Serializable]
class LevelData {
	
}
