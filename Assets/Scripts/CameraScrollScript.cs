using UnityEngine;
using System.Collections;

public class CameraScrollScript : MonoBehaviour {

	public int boundary = 50;
	public int speed = 15;

	private int screenWidth;
	private int screenHeight;

	// Use this for initialization
	void Start () {
		this.screenWidth = Screen.width;
		this.screenHeight = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.mousePosition.x > screenWidth - boundary) {
			transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0);
		}

		if (Input.mousePosition.x < 0 + boundary) {
			transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0);
		}

		if (Input.mousePosition.y > screenHeight - boundary) {
			transform.position = transform.position + new Vector3(0, speed * Time.deltaTime);
		}

		if (Input.mousePosition.y < 0 + boundary) {
			transform.position = transform.position - new Vector3(0, speed * Time.deltaTime);
		}
	}
}
