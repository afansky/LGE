using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShipRegisty {

	private static List<Ship> ships = new List<Ship> ();

	public static Ship AddShip(Ship ship, Star star, Planet planet) 
	{
		ship.planet = planet;
		ship.star = star;

		ships.Add (ship);

		return ship;
	}

	public static List<Ship> GetShipsForPlanet(Planet planet)
	{
		List<Ship> result = new List<Ship> ();
		foreach (Ship ship in ships)
		{
			if(ship.planet.id == planet.id) 
			{
				result.Add(ship);
			}
		}
		return result;
	}
}
