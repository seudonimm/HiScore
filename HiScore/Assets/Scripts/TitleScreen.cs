using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

    public Text scoreText;
    public Text speech;

    public Image guy;
    public Image police;

    public int section;

    // Use this for initialization
    void Start(){
        section = PlayerPrefs.GetInt("end", 0);
        

        if (section == 0)
        {
            speech.text = "You'll never beat my HIGH SCORE!!!";
            scoreText.text = "HIGH SCORE \n" + "1. AAA    12";
        }
        else if(section == 1)
        {
            speech.text = "You'll never beat my HIGH SCORE ever!!!";
            scoreText.text = "HIGH SCORE \n" + "1. AAA    12";
        }
        else if(section == 2)
        {
            speech.text = "You'll never beat my HIGH SCORE ever!!!";
            scoreText.text = "HIGH SCORE \n" + "1. AAA    12";
        }
        else if (section == 3)
        {
            string hi = PlayerPrefs.GetString("hiscore", "");
            speech.text = "CLOSED";
            scoreText.text = "HIGH SCORE \n" + "1. " + hi + "    13";
            guy.sprite = police.sprite;
        }
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.B))
        {
            PlayerPrefs.DeleteAll();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (section == 0)
            {
                SceneManager.LoadScene("Runner");
            }
            else if(section == 1 || section == 3)
            {
                Application.Quit();
            }
            else if(section == 2)
            {
                SceneManager.LoadScene("Runner2");
                speech.text = "How did you do that";
            }
        }
	}
}
