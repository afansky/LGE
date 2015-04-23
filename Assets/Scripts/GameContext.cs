using UnityEngine;
using System.Collections;

public class GameContext {
	private static Player currentPlayer;
	public static Player CurrentPlayer {
		get {
			return currentPlayer;
		}
		set {
			currentPlayer = value;
		}
	}
}
