using UnityEngine;
using System.Collections;

public class StarScript : MonoBehaviour {

	public Star star;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		GameContext.CurrentStar = star;
		Application.LoadLevel ("star_scene");
	}
}
