using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlanetLoadScript : MonoBehaviour {

	public Transform shipPrefab;

	private Planet planet;

	// Use this for initialization
	void Start () {
		planet = GameContext.CurrentPlanet;

		List<Ship> ships = PlayerFleet.GetShipsForPlanet (planet);
		foreach (Ship ship in ships) {
			Transform shipObject = Instantiate (shipPrefab, new Vector3 (ship.x, ship.y, 0), Quaternion.identity) as Transform;
			shipObject.gameObject.GetComponent<ShipScript>().ship = ship;
		}	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerFleet.UpdateShipPositions ();
		List<Ship> ships = PlayerFleet.GetShipsForPlanet (planet);
		foreach(GameObject shipObject in GameObject.FindGameObjectsWithTag("Ship")) {
			foreach(Ship ship in ships) {
				if(shipObject.GetComponent<ShipScript>().ship.id == ship.id) {
					shipObject.transform.position = new Vector3(ship.x, ship.y, 0f);
				}
			}
		}
	}
		
	void OnGUI() {
		if (GUI.Button (new Rect (15, 15, 100, 50), "Back")) {
			Application.LoadLevel("star_scene");
		}
	}
}
