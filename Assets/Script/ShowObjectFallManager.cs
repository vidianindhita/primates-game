using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class ShowObjectFallManager : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	private GameObject fruit_1;
	private GameObject fruit_2;
	private GameObject fruit_3;
	private GameObject fruit_4;
	private GameObject fruit_5;
	private GameObject fruit_6;
	private GameObject fruit_7;
	private GameObject fruit_8;
	private GameObject fruit_9;
	private GameObject fruit_10;

	public Renderer rend;

	public AudioClip pickObject1;
	public AudioClip pickObject2;
	public AudioClip wrongObject1;
	public AudioClip wrongObject2;

	// Use this for initialization
	void Start () {
		// Fruit 1
		fruit_1 = GameObject.Find("1");
		fruit_1.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 2
		fruit_2 = GameObject.Find("2");
		fruit_2.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 3
		fruit_3 = GameObject.Find("3");
		fruit_3.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 4
		fruit_4 = GameObject.Find("4");
		fruit_4.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 5
		fruit_5 = GameObject.Find("5");
		fruit_5.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 6
		fruit_6 = GameObject.Find("6");
		fruit_6.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 7
		fruit_7 = GameObject.Find("7");
		fruit_7.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 8
		fruit_8 = GameObject.Find("8");
		fruit_8.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 9
		fruit_9 = GameObject.Find("9");
		fruit_9.gameObject.GetComponent<Renderer>().enabled = false;

		// Fruit 10
		fruit_10 = GameObject.Find("10");
		fruit_10.gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			if (hit.collider != null) {
				SoundManager.instance.RandomizeSfx (pickObject1, pickObject2);
				Debug.Log(hit.collider.gameObject.name);
				hit.collider.gameObject.GetComponent<Renderer> ().enabled = true;
				score++;
				scoreText.text = "Score: " + score.ToString ();
				Debug.Log ("score: " + score);
			} else if (hit.collider == null) {
				SoundManager.instance.RandomizeSfx (wrongObject1, wrongObject2);
			}
		}
	}
}
