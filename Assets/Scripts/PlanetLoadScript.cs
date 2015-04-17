using UnityEngine;
using System.Collections;

public class PlanetLoadScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneLoadScript.Planet planet = Serializer.Load<SceneLoadScript.Planet> ("planet.st");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void OnGUI() {
		if (GUI.Button (new Rect (15, 15, 100, 50), "Back")) {
			Application.LoadLevel("star_scene");
		}
	}
}
