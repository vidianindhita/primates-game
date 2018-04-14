using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowObjectManager : MonoBehaviour {
	
	public Text scoreText;
	private int score = 0;

	private GameObject orange_1;
	private GameObject orange_2;
	private GameObject orange_3;
	private GameObject orange_4;
	private GameObject orange_5;

	public Renderer rend;

//	private GameObject Oranges;

	// Use this for initialization
	void Start () {
		// Orange 1
		orange_1 = GameObject.Find("orange_1");
		orange_1.gameObject.GetComponent<Renderer>().enabled = false;

		// Orange 2
		orange_2 = GameObject.Find("orange_2");
		orange_2.gameObject.GetComponent<Renderer>().enabled = false;

		// Orange 3
		orange_3 = GameObject.Find("orange_3");
		orange_3.gameObject.GetComponent<Renderer>().enabled = false;

		// Orange 4
		orange_4 = GameObject.Find("orange_4");
		orange_4.gameObject.GetComponent<Renderer>().enabled = false;

		// Orange 5
		orange_5 = GameObject.Find("orange_5");
		orange_5.gameObject.GetComponent<Renderer>().enabled = false;

//		rend = GetComponent<Renderer>();
//		rend.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			if (hit.collider != null) {
				Debug.Log(hit.collider.gameObject.name);
				//hit.collider.attachedRigidbody.AddForce(Vector2.up);
//				Destroy (hit.collider.gameObject);
				hit.collider.gameObject.GetComponent<Renderer> ().enabled = true;
				score++;
				scoreText.text = "Score: " + score.ToString ();
				Debug.Log ("score: " + score);
			}
		}
	}
}
