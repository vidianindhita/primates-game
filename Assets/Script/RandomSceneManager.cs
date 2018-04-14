using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class RandomSceneManager : MonoBehaviour {

	//public string levelToLoad;
	private float timer = 1f;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		int RanNum;
		var levelSpring = "Level 2 Spring";
		var levelFall = "Level 2 Fall";
		var levelSummer = "Level 2 Summer";
		RanNum = Random.Range(0, 2);
		timer -= Time.deltaTime;
		if (timer <= 0) {
			if (RanNum == 1) {
				Application.LoadLevel (levelSpring);
			} else if (RanNum == 0) {
				Application.LoadLevel (levelFall);
			}
		}
	}
}
