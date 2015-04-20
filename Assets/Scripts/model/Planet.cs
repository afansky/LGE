using UnityEngine;
using System.Collections;
using System;

[Serializable()]
public class Planet {
	public string id;
	public int x;
	public int y;
	
	public Planet(int x, int y) {
		this.id = UniqueID.getID ();
		this.x = x;
		this.y = y;
	}
}