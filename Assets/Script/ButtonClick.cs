using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	public AudioClip buttonclicked1;
	public AudioClip buttonclicked2;

	public void LoadScene(string sceneName)
	{
		SoundManager.instance.RandomizeSfx (buttonclicked1, buttonclicked2);
		SceneManager.LoadScene(sceneName);
		Debug.Log ("clicked");
	}
}
