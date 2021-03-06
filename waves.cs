using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class wave {
	public Color32 color;
	public GameObject prefab;
}

public class waves : MonoBehaviour {

	public string waveFileName;
	//public Texture2D LevelMap;

	public wave[] wavep;

	// Use this for initialization
	void Start () {
		LoadWave ();
	}

	void EmptyWave() {
		while (transform.childCount > 0) {
			Transform c = transform.GetChild(0);
			c.SetParent (null);
			Destroy (c.gameObject);
		}
	}


	// LoadWave is called once
	void LoadWave () {
		EmptyWave ();

		string filePath = Application.dataPath + "/Waves/" + waveFileName;

		byte[] bytes = System.IO.File.ReadAllBytes (filePath);
		Texture2D LevelMap = new Texture2D(2,2);
		LevelMap.LoadImage (bytes);

		Color32[] allPixels = LevelMap.GetPixels32 ();
		int width = LevelMap.width;
		int height = LevelMap.height;

		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
		
				SpawnTileAt (allPixels [(y * width) + x], x, y);
			}
		}
	}

	void SpawnTileAt(Color32 c, int x, int y){
		
		foreach (wave wp in wavep) {
			if (wp.color.r == c.r && wp.color.g == c.g && wp.color.b == c.b) {
				GameObject go = (GameObject)Instantiate (wp.prefab, new Vector3 (y*16-32, -46, x*16+64), Quaternion.identity);
				return;
			}
		}
	}
}
