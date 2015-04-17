using UnityEngine;
using System.Collections;

public class StarScript : MonoBehaviour {

	public SceneLoadScript.Star star;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Debug.Log("Star clicked");
		Serializer.Save<SceneLoadScript.Star> ("star.st", star);
		Application.LoadLevel ("star_scene");
	}
}
