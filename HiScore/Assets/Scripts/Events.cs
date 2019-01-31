using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour {
    public int eventCounter;

    public bool e1, e2, e3, e4, ahh;
    public bool n, y, crash;
    public bool e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31;

    //public Text pol;

	// Use this for initialization
	void Start () {
        e1 = false;
        e2 = false;
        e3 = false;
        e4 = false;
        n = false;
        y = false;
        crash = false;
        ahh = false;
        e21 = false;
        e22 = false;
        e23 = false;
        e24 = false;
        e25 = false;
        e26 = false;
        e27 = false;
        e28 = false;
        e29 = false;
        e30 = false;
        e31 = false;

        // pol.text = "";

        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();
        
        gm.speech.text = "Alright, if that's how it is...";

    }

    // Update is called once per frame
    void Update () {
        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();
        PlayerController pc = player.GetComponent<PlayerController>();

        GameObject camera = GameObject.Find("Main Camera");
        Boundary bd = camera.GetComponent<Boundary>();
        if (Input.GetKeyDown("y") && e4)
        {
            gm.speech.text = "Alright, if that's how it is...";
            y = true;
            pc.moveSpeed = 3;
            bd.speed = 3;
        }
        if (Input.GetKeyDown("n") && e4)
        {
            gm.speech.text = "KTHXBYE";
            n = true;
            pc.moveSpeed = 3;
            bd.speed = 3;

          

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();
        PlayerController pc = player.GetComponent<PlayerController>();

        GameObject camera = GameObject.Find("Main Camera");
        Boundary bd = camera.GetComponent<Boundary>();

        int section = PlayerPrefs.GetInt("end", 0);
        //switch stmnt?
        if (section == 0)
        {
            if (gm.score == 12 && e1 == false && !y && !n)
            {
                gm.speech.text = "Your getting pretty close to beating my score...";

                e1 = true;
            }
            else if (gm.score == 12 && e1 && !e2)
            {
                gm.speech.text = "Please don't";

                e2 = true;
            }
            else if (gm.score == 12 && e2 && !e3)
            {
                gm.speech.text = "It's all I have!";
                e3 = true;
                //Application.Quit();
            }
            else if (gm.score == 12 && e3 && !e4)
            {
                gm.speech.text = "Please don't do this\n" + "[DO THIS?]\n" + "Y for yes | N for no";

                pc.moveSpeed = 0;
                bd.speed = 0;
                e4 = true;
            }



            else if (n)
            {
                Debug.Log("crash!!!!");
                //Application.Quit();
                SceneManager.LoadScene("Title");
            }
            else if (y)
            {
                gm.speech.text = "...Then your game ends here";
                PlayerPrefs.SetInt("end", 1);
                Debug.Log("crash!!!!");

                Application.Quit();


            }

        }
        else if (e4 && section == 2)
        {
            if (!e21)
            {
                gm.speech.text = "I'll make sure you never beat my score";

                e21 = true;
            }
            else if(e21 && !e22)
            {
                gm.speech.text = "NOOOOOO!!\n I WON'T ACCEPT THI-";

                e22 = true;
            }
            else if(e21 && e22 && !e23)
            {

                SceneManager.LoadScene("Runner3");
                e23 = true;
            }
            //else if(e21 && e22 && e23 && !e24)
            //{
            //    SceneManager.LoadScene("Runner3");
            //    pol.text = "EVERYBODY GET DOWN THIS IS THE POLICE";
            //    gm.speech.text = "WHAT?";

            //    e24 = true;
            //}
            //else if(e21 && e22 && e23 && e24 && !e25)
            //{
            //    pol.text = "Your under arrest for game tampering and holding hostage a high score!";
            //    gm.speech.text = "*sounds of arrest*";

            //    e25 = true;
            //}
            //else if (e21 && e22 && e23 && e24 && e25 && !e26)
            //{
            //    pol.text = "Hi we've been trying get this perp for a while now, but were not allowed to arrest high score holders";
            //    gm.speech.text = "";

            //    e26 = true;
            //}
            //else if (e21 && e22 && e23 && e24 && e25 && e26 && !e27)
            //{
            //    pol.text = "That's why we gave the ANTI SHUTDOWN so you could beat him";
            //    gm.speech.text = "";

            //    e27 = true;
            //}
            //else if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && !e28)
            //{
            //    pol.text = "Unfortunately, now that theres no one here to man this game it will have to be shut down";
            //    gm.speech.text = "";

            //    e28 = true;
            //}
            //else if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && e28 && !e29)
            //{
            //    pol.text = "But before we do that what are your initials: ";
            //    gm.speech.text = "";

            //    pc.moveSpeed = 0;
            //    bd.speed = 0;

            //    e29 = true;
            //}
            //else if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && e28 && e29 && !e30)
            //{
            //    pol.text = "Thanks for your coooperation, Bye";
            //    gm.speech.text = "";

            //    pc.moveSpeed = 3;
            //    bd.speed = 3;

            //    e30 = true;
            //}
            //else if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && e28 && e29 && e30 && !e31)
            //{
            //    pol.text = "Thanks for your coooperation, Bye";
            //    gm.speech.text = "";

            //    e31 = true;

            //    PlayerPrefs.SetInt("end", 3);
            //    Application.Quit();
            //}



        }
        else if(section == 2)
        {
            if (gm.score == 12 && e1 == false)
            {
                gm.speech.text = "No matter, I'll just shut down the-";

                e1 = true;
            }
            else if (gm.score == 12 && e1 && !e2)
            {
                gm.speech.text = "What did you do, it's not working!!";

                e2 = true;
            }
            else if (gm.score == 12 && e2 && !e3)
            {
                gm.speech.text = "I don't know what you did. but if you want my HIGH SCORE-";
                e3 = true;
                //Application.Quit();
            }
            else if (gm.score == 12 && e3 && !e4)
            {
                gm.speech.text = "Your gonna have to work for it";

                //pc.moveSpeed = 0;
                //bd.speed = 0;
                e4 = true;
                
            }
        }
    }
}
