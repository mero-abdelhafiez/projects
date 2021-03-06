﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour {

	public Text TimeText;
	public Text PointsText;
	public Image backgroundimg;
	private bool isShown = false;
	private float transition = 0.0f;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (!isShown)
			return;
		transition += Time.deltaTime;
		backgroundimg.color = Color.Lerp (new Color (0, 0, 0, 0),Color.black,transition);
	}

	public void ToggleEndMenu(float timeScore,int pointsScore){
		gameObject.SetActive (true);
		TimeText.text = ((int)timeScore).ToString ();
		PointsText.text = pointsScore.ToString ();
		isShown = true;
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void ToMenu(){
		SceneManager.LoadScene ("Menu");
	}
}
