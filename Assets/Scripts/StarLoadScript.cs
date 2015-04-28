using UnityEngine;
using System.Collections;

public class StarLoadScript : MonoBehaviour {

	public Transform planet;
	public Transform starPrefab;

	// Use this for initialization
	void Start () {
		Star star = GameContext.CurrentStar;
		Instantiate (starPrefab, new Vector3 (0, 0, 0), Quaternion.identity);

		foreach (Planet planetModel in star.planets) {
			Transform planetObject = Instantiate (planet, new Vector3 (planetModel.x, planetModel.y, 0), Quaternion.identity) as Transform;
			planetObject.gameObject.GetComponent<PlanetScript>().planet = planetModel;
		}
	}
	
	// Update is called once per frame
	void Update () {
		PlayerFleet.UpdateShipPositions ();
	}

	void OnGUI() {
		if (GUI.Button (new Rect (15, 15, 100, 50), "Back")) {
			Application.LoadLevel("star_group_scene");
		}
	}
}
