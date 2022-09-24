using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing; 

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.HasKey(" ")) 
        {
            hiScoreCount = PlayerPrefs.GetFloat(" ");
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat(" ", hiScoreCount); 
        }

        scoreText.text = " " + Mathf.Round(scoreCount);
        hiScoreText.text = " " + Mathf.Round (hiScoreCount);
	}
}
