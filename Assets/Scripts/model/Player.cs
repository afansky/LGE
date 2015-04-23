using UnityEngine;
using System.Collections;

public class Player {
	private string id = UniqueID.getID();
	public string Id {
		get {
			return id;
		}
	}
}
