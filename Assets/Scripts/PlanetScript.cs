using UnityEngine;
using System.Collections;

public class PlanetScript : MonoBehaviour {

	public SceneLoadScript.Planet planet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Debug.Log("Planet clicked");
		Serializer.Save<SceneLoadScript.Planet> ("planet.st", planet);
		Application.LoadLevel ("planet_scene");
	}

}
