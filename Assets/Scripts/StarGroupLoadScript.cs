using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class StarGroupLoadScript : MonoBehaviour {

	public Transform star;

	// Use this for initialization
	void Start () {
		Debug.Log("Scene started");

		List<Star> stars = GenerateStars ();
		foreach (Star starModel in stars) {
			Debug.Log("Creating a star");
			Transform instance = Instantiate (star, new Vector3 (starModel.x, starModel.y, 0), Quaternion.identity) as Transform;
			instance.GetComponent<StarScript>().star = starModel;
		}
	}
	
	// Update is called once per frame
	void Update () {
		PlayerFleet.UpdateShipPositions ();
	}

	List<Star> GenerateStars ()
	{
		List<Star> stars = new List<Star>();
		stars.Add (createFirstStar ());
		stars.Add (createSecondStar ());
		stars.Add (createThirdStar ());
		return stars;
	}

	Star createFirstStar ()
	{
		List<Planet> planets = new List<Planet> ();
		Planet planet = new Planet (10, 10);
		planets.Add (planet);
		planets.Add (new Planet (0, 10));
		planets.Add (new Planet (10, 0));
		Star star = new Star (-10, -10, planets);
		PlayerFleet.AddShip (new Ship (10, 10), star, planet);
		PlayerFleet.AddShip (new Ship (0, 30), star, planet);
		return star;
	}

	private Planet createPlanetWithShip(int x, int y, Star star) 
	{
		Planet planet = new Planet (x, y);

		Ship ship = new Ship (15, 15);

		PlayerFleet.AddShip (ship, star, planet);

		return planet;
	}

	Star createSecondStar ()
	{
		Planet planet = new Planet (-10, -10);
		List<Planet> planets = new List<Planet> ();
		planets.Add (planet);
		return new Star (0, 0, planets);
	}

	Star createThirdStar ()
	{
		Planet planet = new Planet (0, 0);
		List<Planet> planets = new List<Planet> ();
		planets.Add (planet);
		return new Star (10, 10, planets);
	}

}
