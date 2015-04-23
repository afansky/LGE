using UnityEngine;
using System.Collections;

public class Ship {
	public string id = UniqueID.getID();
	public float x;
	public float y;
	public Star star;
	public Planet planet;
	public float speed = 5.0f;
	public Vector3 destination;

	public Ship(float x, float y) {
		this.x = x;
		this.y = y;
	}

	public bool IsMoving() {
		return !Mathf.Approximately (x, destination.x)
			|| !Mathf.Approximately (y, destination.y);
	}
}
