using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlanetLoadScript : MonoBehaviour {

	public Transform shipPrefab;

	// Use this for initialization
	void Start () {
		Planet planet = Serializer.Load<Planet> ("planet.st");

		List<Ship> ships = ShipRegisty.GetShipsForPlanet (planet);
		foreach (Ship ship in ships) {
			Instantiate (shipPrefab, new Vector3 (ship.x, ship.y, 0), Quaternion.identity);
		}	
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
