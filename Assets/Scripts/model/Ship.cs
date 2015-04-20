using UnityEngine;
using System.Collections;

public class Ship {
	public int x;
	public int y;
	public Star star;
	public Planet planet;

	public Ship(int x, int y) {
		this.x = x;
		this.y = y;
	}
}
