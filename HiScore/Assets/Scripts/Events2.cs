using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Events2 : MonoBehaviour {

    public bool e1, e2, e3, e4, ahh;
    public bool n, y, crash;
    public bool e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31;

    public Text pol;

    public int i = 0;

    // Use this for initialization
    void Start () {
        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();

        e1 = false;
        e2 = false;
        e3 = false;
        e4 = false;
        n = false;
        y = false;
        crash = false;
        ahh = false;
        e21 = true;
        e22 = true;
        e23 = true;
        e24 = false;
        e25 = false;
        e26 = false;
        e27 = false;
        e28 = false;
        e29 = false;
        e30 = false;
        e31 = false;

        gm.speech.text = "NOOOOOO!!\n I WON'T ACCEPT THI-";

    }

    // Update is called once per frame
    void Update () {

        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();

        if (i == 0)
        {
            e21 = true;
            e22 = true;
            e23 = true;
            e24 = false;
            e25 = false;
            e26 = false;
            e27 = false;
            e28 = false;
            e29 = false;
            e30 = false;
            e31 = false;

            //gm.speech.text = "NOOOOOO!!\n I WON'T ACCEPT THI-";

            pol.text = "EVERYBODY GET DOWN THIS IS THE POLICE";
            gm.speech.text = "WHAT?";


            i = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();
        PlayerController pc = player.GetComponent<PlayerController>();

        GameObject camera = GameObject.Find("Main Camera");
        Boundary bd = camera.GetComponent<Boundary>();


        if (e21 && e22 && e23 && !e24)
        {
         
            pol.text = "EVERYBODY GET DOWN THIS IS THE POLICE";
            gm.speech.text = "WHAT?";

            e24 = true;
        }
        else if (e21 && e22 && e23 && e24 && !e25)
        {
            pol.text = "You're under arrest for game tampering and holding hostage a high score!";
            gm.speech.text = "*sounds of arrest*";

            e25 = true;
        }
        else if (e21 && e22 && e23 && e24 && e25 && !e26)
        {
            pol.text = "Hi we've been trying get this guy for a while now, but we're not allowed to arrest high score holders";
            gm.speech.text = "";

            e26 = true;
        }
        else if (e21 && e22 && e23 && e24 && e25 && e26 && !e27)
        {
            pol.text = "That's why we gave you the PREVENT CRASH so you could beat him";
            gm.speech.text = "";

            e27 = true;
        }
        else if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && !e28)
        {
            pol.text = "Unfortunately, now that theres no one here to man this game it will have to be shut down";
            gm.speech.text = "";

            e28 = true;
        }
        else if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && e28 && !e29)
        {
            SceneManager.LoadScene("end");
            //pol.text = "But before we do that what are your initials: ";
            //gm.speech.text = "";

            //pc.moveSpeed = 0;
            //bd.speed = 0;

            //e29 = true;
        }
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
}
