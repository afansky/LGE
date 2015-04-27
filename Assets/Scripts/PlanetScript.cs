using UnityEngine;
using System.Collections;

public class PlanetScript : MonoBehaviour {

	public Planet planet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		GameContext.CurrentPlanet = planet;
		Application.LoadLevel ("planet_scene");
	}

}
