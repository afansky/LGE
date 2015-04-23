using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {

	private Vector3 target;
	public Ship ship;
	private bool selected;

	// Use this for initialization
	void Start () {
		ship.destination = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && selected) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray, out hit)) {
				//clicked the ship
				if(hit.transform == transform) {
				} 
			} else {
				Vector3 newPosition = ray.GetPoint(-Camera.main.transform.position.z);
				newPosition.z = 0;
				ship = ShipRegisty.UpdateShipDestination(ship, newPosition);
			}

		}
	}

	void OnMouseDown() {
		foreach(GameObject shipObject in GameObject.FindGameObjectsWithTag("Ship")) {
			shipObject.SendMessage("Deselect");
		}

		selected = true;
		GetComponent<SpriteRenderer> ().color = Color.red;
	}

	public void Deselect() {
		selected = false;
		GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
