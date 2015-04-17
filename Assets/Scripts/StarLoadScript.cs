using UnityEngine;
using System.Collections;

public class StarLoadScript : MonoBehaviour {

	public Transform planet;

	// Use this for initialization
	void Start () {
		SceneLoadScript.Star star = Serializer.Load<SceneLoadScript.Star> ("star.st");
		foreach (SceneLoadScript.Planet planetModel in star.planets) {
			Instantiate (planet, new Vector3 (planetModel.x, planetModel.y, planetModel.z), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (15, 15, 100, 50), "Back")) {
			Application.LoadLevel("star_group_scene");
		}
	}
}
