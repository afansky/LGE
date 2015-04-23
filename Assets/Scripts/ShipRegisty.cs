using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShipRegisty {

	private static List<Ship> ships = new List<Ship> ();

	public static Ship AddShip(Ship ship, Star star, Planet planet) {
		ship.planet = planet;
		ship.star = star;

		ships.Add (ship);

		return ship;
	}

	public static List<Ship> GetShipsForPlanet(Planet planet) {
		List<Ship> result = new List<Ship> ();
		foreach (Ship ship in ships) {
			if(ship.planet.id == planet.id) {
				result.Add(ship);
			}
		}
		return result;
	}

	public static Ship UpdateShipDestination(Ship ship, Vector3 destination) {
		foreach (Ship s in ships) {
			if(s.id == ship.id) {
				s.destination = destination;
				ship.destination = destination;
			}
		}
		return ship;
	}

	public static void UpdateShipPositions() {
		foreach (Ship ship in ships) {
			if (ship.IsMoving()) {
				Vector3 newPosition = Vector2.MoveTowards (new Vector3(ship.x, ship.y, 0), ship.destination, ship.speed * Time.deltaTime);
				ship.x = newPosition.x;
				ship.y = newPosition.y;
			}
		}
	}
}
