using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public static class SaveLoad {
	public static Background Level = new Background();

	public static void Save() {
		Level = Background.Current;
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/" + Background.LevelName + ".pv");
		bf.Serialize (file, SaveLoad.Level);
		file.Close ();
	}

	public static void Load() {
		if (File.Exists (Application.persistentDataPath + "/" + Background.LevelName + ".pv")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/" + Background.LevelName + ".pv", FileMode.Open);
			SaveLoad.Level = (Background)bf.Deserialize (file);
			file.Close ();
		}
	}
}
