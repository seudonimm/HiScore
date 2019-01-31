using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public float score;

    public int section;
    public int e;

    public Text scoreText;
    public Text speech;

    public BoxCollider2D bc;
	// Use this for initialization
	void Start () {
        score = 0;
        SetCountText();
        speech.text = "You'll never beat my HIGH SCORE!!!";

    }

    // Update is called once per frame
    void Update () {
        SetCountText();
    }

    void SetCountText()
    {
        section = PlayerPrefs.GetInt("end", 0);
        if (section == 0)
        {
            scoreText.text = "Score: " + score.ToString();
            if (score > 0 && score < 5)
            {
                speech.text = "Pathetic";
            }
            if (score > 5 && score < 8)
            {
                speech.text = "Still not good";
            }
            if (score > 8 && score < 10)
            {
                speech.text = "getting pretty close...";
            }
            if (score == 11)
            {
                speech.text = "...";
            }
        }
        else if(section == 2)
        {
            score = 12;
            scoreText.text = "Score: " + score.ToString();
            if (score > 0 && score < 5)
            {
                speech.text = "Pathetic";
            }
            if (score > 5 && score < 8)
            {
                speech.text = "Still not good";
            }
            if (score > 8 && score < 10)
            {
                speech.text = "getting pretty close...";
            }
            if (score == 11)
            {
                speech.text = "...";
            }
        }
    }


}
