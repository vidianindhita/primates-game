using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour {

	public string levelToLoad;
	private float timer = 10f;
	private Text timerSecods;

	// Use this for initialization
	void Start () {
		timerSecods = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		timerSecods.text = timer.ToString ("f2");
		if (timer <= 0) {
			Application.LoadLevel (levelToLoad);
		}
	}
}
