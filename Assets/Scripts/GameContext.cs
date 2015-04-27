using UnityEngine;
using System.Collections;

public class GameContext {
	private static Player currentPlayer;
	private static Star currentStar;
	private static Planet currentPlanet;

	public static Player CurrentPlayer {
		get {
			return currentPlayer;
		}
		set {
			currentPlayer = value;
		}
	}
	
	public static Star CurrentStar {
		get {
			return currentStar;
		}
		set {
			currentStar = value;
		}
	}

	public static Planet CurrentPlanet {
		get {
			return currentPlanet;
		}
		set {
			currentPlanet = value;
		}
	}
}
