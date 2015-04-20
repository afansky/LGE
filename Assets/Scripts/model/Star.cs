using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[Serializable()]
public class Star {
	public int x;
	public int y;
	public List<Planet> planets;
	
	public Star(int x, int y, List<Planet> planets) {
		this.x = x;
		this.y = y;
		this.planets = planets;
	}
}
