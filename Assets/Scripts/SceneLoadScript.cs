using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class SceneLoadScript : MonoBehaviour {

	public Transform star;

	// Use this for initialization
	void Start () {
		Debug.Log("Scene started");

		List<Star> stars = GenerateStars ();
		foreach (Star starModel in stars) {
			Debug.Log("Creating a star");
			Transform instance = Instantiate (star, new Vector3 (starModel.x, starModel.y, starModel.z), Quaternion.identity) as Transform;
			instance.GetComponent<StarScript>().star = starModel;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
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
		planets.Add (new Planet (10, 10, 0));
		planets.Add (new Planet (0, 10, 0));
		planets.Add (new Planet (10, 0, 0));
		return new Star (-10, -10, 0, planets);
	}

	Star createSecondStar ()
	{
		Planet planet = new Planet (-10, -10, 0);
		List<Planet> planets = new List<Planet> ();
		planets.Add (planet);
		return new Star (0, 0, 0, planets);
	}

	Star createThirdStar ()
	{
		Planet planet = new Planet (0, 0, 0);
		List<Planet> planets = new List<Planet> ();
		planets.Add (planet);
		return new Star (10, 10, 0, planets);
	}

	[Serializable()]
	public class Star {
		public int x;
		public int y;
		public int z;
		public List<Planet> planets;

		public Star(int x, int y, int z, List<Planet> planets) {
			this.x = x;
			this.y = y;
			this.z = z;
			this.planets = planets;
		}
	}

	[Serializable()]
	public class Planet {
		public int x;
		public int y;
		public int z;

		public Planet(int x, int y, int z) {
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}
}
