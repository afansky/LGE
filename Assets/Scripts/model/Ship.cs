using UnityEngine;
using System.Collections;

public class Ship {
	public string id = UniqueID.getID();
	public float x;
	public float y;
	public Star star;
	public Planet planet;
	public float speed = 5.0f;
	public Vector3? destination = null;

	private Player player;
	public Player Player {
		get {
			return player;
		}
		set {
			player = value;
		}
	}

	public Ship(float x, float y) {
		this.x = x;
		this.y = y;
	}

	public bool IsMoving() {
		return destination.HasValue && (!Mathf.Approximately (x, destination.GetValueOrDefault().x)
			|| !Mathf.Approximately (y, destination.GetValueOrDefault().x));
	}

	public bool IsOwner(Player owner) {
		return player.Id == owner.Id;
	}
}
